﻿using AutoMapper;
using Azure.Core;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
using SecurityGateApv.Domain.Interfaces.Jwt;
using SecurityGateApv.Domain.Interfaces.Notifications;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services
{
    public class VisitorSessionService : IVisitorSessionService
    {
        private readonly IVisitorSessionRepo _visitorSessionRepo;
        private readonly IVehicleSessionRepo _vehicleSessionRepo;
        private readonly ICardRepo _cardRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVisitDetailRepo _visitDetailRepo;
        private readonly IVisitCardRepo _visitCardRepo;
        private readonly ICardService _qrCodeService;
        private readonly IVisitorRepo _visitorRepo;
        private readonly IVisitorSessionImagesRepo _visitorSessionImagesRepo;
        private readonly IJwt _jwt;
        private readonly INotifications _notifications;
        private readonly INotificationRepo _notificationRepo;

        public VisitorSessionService(IVisitorSessionRepo visitorSessionRepo, IMapper mapper, IUnitOfWork unitOfWork, ICardRepo qRCardRepo, IVisitDetailRepo visitDetailRepo,
            IVisitCardRepo visitCardRepo, ICardService cardService, IJwt jwt, IVisitorRepo visitorRepo, IVisitorSessionImagesRepo visitorSessionImagesRepo,
            INotifications notifications, INotificationRepo notificationRepo, IVehicleSessionRepo vehicleSessionRepo)
        {
            _visitorSessionRepo = visitorSessionRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _cardRepo = qRCardRepo;
            _visitDetailRepo = visitDetailRepo;
            _visitCardRepo = visitCardRepo;
            _qrCodeService = cardService;
            _jwt = jwt;
            _visitorRepo = visitorRepo;
            _visitorSessionImagesRepo = visitorSessionImagesRepo;
            _notifications = notifications;
            _notificationRepo = notificationRepo;
            _vehicleSessionRepo = vehicleSessionRepo;
        }

        public async Task<Result<ValidCheckinRes>> CheckInWithCredentialCard(VisitSessionCheckInCommand command)
        {
            var visitDetails = await _visitDetailRepo.FindAsync(
                s => s.Visitor.CredentialsCard.Equals(command.CredentialCard)
                && s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date
                && s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date
                //&& s.ExpectedStartHour <= DateTime.Now.TimeOfDay
                //&& s.ExpectedEndHour >= DateTime.Now.TimeOfDay
                && (s.Visit.VisitStatus == VisitStatusEnum.Active.ToString() || s.Visit.VisitStatus == VisitStatusEnum.ActiveTemporary.ToString()),
                int.MaxValue, 1, includeProperties: "Visit.ScheduleUser.Schedule.ScheduleType,Visitor"
            );
            var validVisitDetail = visitDetails.FirstOrDefault(visitDetail => IsValidVisit(visitDetail.Visit, DateTime.Now));
            if (validVisitDetail == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundVisitByCredentialCard);
            }
            //if(validVisitDetail.Visit.VisitStatus == VisitStatusEnum.Cancelled.ToString())
            //{
            //    return Result.Failure<ValidCheckinRes>(Error.);
            //}
            // Check exist Card and does not have visit
            var card = (await _cardRepo.FindAsync(
                s => s.CardVerification.Equals(command.QRCardVerification),
                includeProperties: "CardType"
                ))
                .FirstOrDefault();
            if (card == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundCard);
            }
            if (card.CardStatus == CardStatusEnum.Inactive.ToString())
            {
                return Result.Failure<ValidCheckinRes>(Error.CardInActive);
            }
            if (card.CardStatus == CardStatusEnum.Lost.ToString())
            {
                return Result.Failure<ValidCheckinRes>(Error.CardLost);
            }



            // Check valid CredentialCard and Card 
            var visitCard = (await _visitCardRepo.FindAsync(
                s => (s.CardId == card.CardId && s.VisitDetailId == validVisitDetail.VisitDetailId)
                && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString())
            )).FirstOrDefault();
            if (visitCard != null)
            {
                return Result.Failure<ValidCheckinRes>(Error.DuplicateCard);
            }
            //if (visitCard != null && visitCard.VisitDetailId != validVisitDetail.VisitDetailId)
            //{
            //    return Result.Failure<ValidCheckinRes>(Error.DuplicateVisitDetail);
            //}

            // Check session don't have check-in
            var visitSession = (await _visitorSessionRepo.FindAsync(
                s => s.VisitDetailId == validVisitDetail.VisitDetailId && s.Status == SessionStatus.CheckIn.ToString(),
                1, 1
            )).FirstOrDefault();

            if (visitSession != null)
            {
                return Result.Failure<ValidCheckinRes>(Error.ValidSession);
            }

            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = Result.Success<AWSDomainDTO>(null);
            try
            {
                var shoeImage = command.Images.FirstOrDefault(s => s.ImageType == "Shoe");
                if (shoeImage == null)
                {
                    return Result.Failure<ValidCheckinRes>(Error.NotShoe);
                }

                detectShoeResult = await _qrCodeService.DetectShoe(shoeImage.Image);
                if (!detectShoeResult.Value.Label.Equals("Shoe"))
                {
                    return Result.Failure<ValidCheckinRes>(Error.NotShoe);
                }
                if (detectShoeResult.IsFailure)
                {
                    return Result.Failure<ValidCheckinRes>(detectShoeResult.Error);
                }
            }
            catch
            {
                return Result.Failure<ValidCheckinRes>(Error.DetectionExeption);
            }

            //Vehicle Session
            if (command.VehicleSession != null)
            {
                var vehicleSession = (await _vehicleSessionRepo.FindAsync(
                        s => s.LicensePlate == command.VehicleSession.LicensePlate && s.Status == SessionStatus.CheckIn.ToString()
                    )).FirstOrDefault();
                if (vehicleSession != null)
                {
                    return Result.Failure<ValidCheckinRes>(Error.ValidVehicleSession);
                }
                var vehicleSessionCheckin = VehicleSession.Checkin(command.VehicleSession.LicensePlate, validVisitDetail.VisitDetailId, command.SecurityInId, command.GateInId);
                if (vehicleSessionCheckin.IsFailure)
                {
                    return Result.Failure<ValidCheckinRes>(vehicleSessionCheckin.Error);
                }
                var vehicleSessionEntity = vehicleSessionCheckin.Value;

                foreach (var item in command.Images)
                {
                    vehicleSessionEntity.AddVehicleSessionImage(item.ImageType, item.ImageURL);
                }
                await _vehicleSessionRepo.AddAsync(vehicleSessionEntity);
            }

            // Add VisitCard
            if (visitCard == null)
            {
                if ((validVisitDetail.Visit.ScheduleUser == null
                    && card.CardType.CardTypeName == CardTypeEnum.ShotTermCard.ToString()))
                {
                    visitCard = VisitCard.Create(DateTime.Now, validVisitDetail.Visit.ExpectedEndTime, "Issue", validVisitDetail.VisitDetailId, card.CardId);
                }
                else if (card.CardType.CardTypeName == CardTypeEnum.LongTermCard.ToString()
                    && validVisitDetail.Visit.ScheduleUser != null
                    )
                {
                    visitCard = VisitCard.Create(DateTime.Now, validVisitDetail.Visit.ExpectedEndTime, "Issue", validVisitDetail.VisitDetailId, card.CardId);
                }
                else
                {
                    var error = Error.ScheduleAndCardTypeMismatch(validVisitDetail.Visit.ScheduleUser == null ? "Visit Daily" : validVisitDetail.Visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName, card.CardType.CardTypeName);
                    return Result.Failure<ValidCheckinRes>(error);
                }
                await _visitCardRepo.AddAsync(visitCard);

            }


            var checkinSession = VisitorSession.Checkin(validVisitDetail.VisitDetailId, command.SecurityInId, command.GateInId);
            if (checkinSession.IsFailure)
            {
                return Result.Failure<ValidCheckinRes>(checkinSession.Error);
            }
            var session = checkinSession.Value;

            foreach (var item in command.Images)
            {
                session.AddVisitorImage(item.ImageType, item.ImageURL);
            }
            var result = _mapper.Map<ValidCheckinRes>(validVisitDetail);
            result.CardRes = _mapper.Map<CardRes>(card);
            result.DetectShoeRes = detectShoeResult.Value;
            result.Sessions = _mapper.Map<SessionsRes>(checkinSession.Value);
            //var result = new CheckInRes()
            //{
            //    VisitDetailId = validVisitDetail.VisitDetailId,
            //    SecurityInId = command.SecurityInId,
            //    GateInId = command.GateInId,
            //    Card = _mapper.Map<GetCardRes>(qrCard),
            //    SessionsImageRes = _mapper.Map<SessionsRes>(checkinSession.Value),
            //    DetectShoeRes = detectShoeResult.Value,
            //};
            await _visitorSessionRepo.AddAsync(checkinSession.Value);
            if (!await _unitOfWork.CommitAsync())
            {
                return Result.Failure<ValidCheckinRes>(Error.CheckInFail);
            };


            //send Notification to Staff
            var user = validVisitDetail.Visitor;
            var noti = Notification.Create($"Check-in từ chuyến thăm, Khách: {user.VisitorName}  ", $"Khách {user.VisitorName} đã check-in", validVisitDetail.Visit.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
            noti.Value.AddUserNoti(command.SecurityInId, (int)validVisitDetail.Visit.ResponsiblePersonId);
            await _notificationRepo.AddAsync(noti.Value);
            var commit2 = await _unitOfWork.CommitAsync();
            if (!commit2)
            {
                return Result.Failure<ValidCheckinRes>(Error.CommitError);
            }
            await _notifications.SendMessageAssignForStaff("New visit", "Temporary Visit", (int)validVisitDetail.Visit.ResponsiblePersonId, 1);

            return result;
        }

        public async Task<Result<ValidCheckinRes>> CheckInWithoutCredentialCard(VisitSessionCheckInCommand command)
        {
            var card = (await _cardRepo.FindAsync(
                    s => s.CardVerification == command.QRCardVerification && s.CardStatus.Equals(CardStatusEnum.Active.ToString())
                )).FirstOrDefault();
            if (card == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundCard);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                    s => s.CardId == card.CardId
                    && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString())
                    && s.ExpiryDate.Date >= DateTime.Now.Date
                )).FirstOrDefault();
            if (visitCard == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundVisitCard);
            }

            var visitDetails = await _visitDetailRepo.FindAsync(
                   s => s.VisitDetailId == visitCard.VisitDetailId
                   && s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date
                   && s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date
                   && (s.Visit.VisitStatus == VisitStatusEnum.Active.ToString() || s.Visit.VisitStatus == VisitStatusEnum.ActiveTemporary.ToString()),
                   int.MaxValue, 1, includeProperties: "Visit.ScheduleUser.Schedule.ScheduleType,Visitor"
                );
            var validVisitDetail = visitDetails.FirstOrDefault(visitDetail => IsValidVisit(visitDetail.Visit, DateTime.Now));
            if (validVisitDetail == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundVisitByCredentialCard);
            }

            //Check session don't have checkin
            var visitSesson = (await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetailId == validVisitDetail.VisitDetailId && s.Status == SessionStatus.CheckIn.ToString(),
                  1, 1
              )).FirstOrDefault();
            if (visitSesson != null)
            {
                return Result.Failure<ValidCheckinRes>(Error.ValidSession);
            }

            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = Result.Success<AWSDomainDTO>(null);
            try
            {
                var shoeImage = command.Images.FirstOrDefault(s => s.ImageType == "Shoe");
                if (shoeImage == null)
                {
                    return Result.Failure<ValidCheckinRes>(Error.NotShoe);
                }

                detectShoeResult = await _qrCodeService.DetectShoe(shoeImage.Image);
                if (!detectShoeResult.Value.Label.Equals("Shoe"))
                {
                    return Result.Failure<ValidCheckinRes>(Error.NotShoe);
                }
                if (detectShoeResult.IsFailure)
                {
                    return Result.Failure<ValidCheckinRes>(detectShoeResult.Error);
                }
            }
            catch
            {
                return Result.Failure<ValidCheckinRes>(Error.DetectionExeption);
            }

            //Vehicle Session
            if (command.VehicleSession != null)
            {
                var vehicleSession = (await _vehicleSessionRepo.FindAsync(
                        s => s.LicensePlate == command.VehicleSession.LicensePlate && s.Status == SessionStatus.CheckIn.ToString()
                    )).FirstOrDefault();
                if (vehicleSession != null)
                {
                    return Result.Failure<ValidCheckinRes>(Error.ValidVehicleSession);
                }
                var vehicleSessionCheckin = VehicleSession.Checkin(command.VehicleSession.LicensePlate, validVisitDetail.VisitDetailId, command.SecurityInId, command.GateInId);
                if (vehicleSessionCheckin.IsFailure)
                {
                    return Result.Failure<ValidCheckinRes>(vehicleSessionCheckin.Error);
                }
                var vehicleSessionEntity = vehicleSessionCheckin.Value;

                foreach (var item in command.Images)
                {
                    vehicleSessionEntity.AddVehicleSessionImage(item.ImageType, item.ImageURL);
                }
                await _vehicleSessionRepo.AddAsync(vehicleSessionEntity);
            }


            var checkinSession = VisitorSession.Checkin(validVisitDetail.VisitDetailId, command.SecurityInId, command.GateInId);
            if (checkinSession.IsFailure)
            {
                return Result.Failure<ValidCheckinRes>(checkinSession.Error);
            }
            var session = checkinSession.Value;

            foreach (var item in command.Images)
            {
                session.AddVisitorImage(item.ImageType, item.ImageURL);
            }

            var result = _mapper.Map<ValidCheckinRes>(validVisitDetail);
            result.CardRes = _mapper.Map<CardRes>(card);
            result.DetectShoeRes = detectShoeResult.Value;
            result.Sessions = _mapper.Map<SessionsRes>(checkinSession.Value);
            //var result = new CheckInRes()
            //{
            //    VisitDetailId = validVisitDetail.VisitDetailId,
            //    SecurityInId = command.SecurityInId,
            //    GateInId = command.GateInId,
            //    Card = _mapper.Map<GetCardRes>(card),
            //    SessionsImageRes = _mapper.Map<SessionsRes>(checkinSession.Value),
            //    DetectShoeRes = detectShoeResult.Value,
            //};
            await _visitorSessionRepo.AddAsync(checkinSession.Value);
            if (!await _unitOfWork.CommitAsync())
            {
                return Result.Failure<ValidCheckinRes>(Error.CheckInFail);
            };
            var user = validVisitDetail.Visitor;
            var noti = Notification.Create($"Check-in từ chuyến thăm, Khách: {user.VisitorName}  ", $"Khách {user.VisitorName} đã check-in", validVisitDetail.Visit.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
            noti.Value.AddUserNoti(command.SecurityInId, (int)validVisitDetail.Visit.ResponsiblePersonId);
            await _notificationRepo.AddAsync(noti.Value);
            var commit2 = await _unitOfWork.CommitAsync();
            if (!commit2)
            {
                return Result.Failure<ValidCheckinRes>(Error.CommitError);
            }
            await _notifications.SendMessageAssignForStaff("New visit", "Temporary Visit", (int)validVisitDetail.Visit.ResponsiblePersonId, 1);

            return result;
        }

        public async Task<Result<ValidCheckinRes>> ValidCheckWithCredentialCardIn(ValidCheckInCommand command)
        {
            //Check exsit credentialcard and have visit valid
            //var credentialCardCheck = (await _visitorRepo.FindAsync(s => s.CredentialsCard == command.CredentialCard
            //&& s.Status.Equals(VisitorStatusEnum.Active.ToString()),
            //includeProperties: "VisitDetail.Visit"
            //)).FirstOrDefault();


            var visitDetails = await _visitDetailRepo.FindAsync(
               s => s.Visitor.CredentialsCard.Equals(command.CredentialCard)
               /*&& s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date*/
               && s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date,
               int.MaxValue, 1, includeProperties: "Visit.ScheduleUser.Schedule.ScheduleType,Visitor"
               );
            var validVisitDetail = visitDetails.FirstOrDefault(visitDetail => IsValidVisit(visitDetail.Visit, DateTime.Now));
            if (validVisitDetail == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundVisitByCredentialCard);
            }

            //Check exsit Card and dos not have visit
            var qrCard = (await _cardRepo.FindAsync(
               s => s.CardVerification.Equals(command.QRCardVerification)))
               .FirstOrDefault();
            if (qrCard == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundCard);
            }
            //Check valid CredentialCard and Card 
            var visitCard = (await _visitCardRepo.FindAsync(
                               s => (s.CardId == qrCard.CardId && s.VisitDetailId == validVisitDetail.VisitDetailId)
                               && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString())
                                              )).FirstOrDefault();
            if (visitCard != null && visitCard.CardId != qrCard.CardId)
            {
                return Result.Failure<ValidCheckinRes>(Error.DuplicateCard);
            }
            if (visitCard != null && visitCard.VisitDetailId == validVisitDetail.VisitDetailId)
            {
                return Result.Failure<ValidCheckinRes>(Error.DuplicateVisitDetail);
            }
            //Check session don't have checkin
            var visitSesson = (await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetailId == validVisitDetail.VisitDetailId && s.Status == SessionStatus.CheckIn.ToString(),
                  1, 1
              )).FirstOrDefault();
            if (visitSesson != null)
            {
                return Result.Failure<ValidCheckinRes>(Error.ValidSession);
            }

            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = null;
            try
            {
                detectShoeResult = await _qrCodeService.DetectShoe(command.ImageShoe);
                if (!detectShoeResult.Value.Label.Equals("Shoe"))
                {
                    return Result.Failure<ValidCheckinRes>(Error.NotShoe);
                }
                if (detectShoeResult.IsFailure)
                {
                    return Result.Failure<ValidCheckinRes>(detectShoeResult.Error);
                }
            }
            catch (Exception ex)
            {
                return Result.Failure<ValidCheckinRes>(Error.DetectionExeption);
            }

            var result = _mapper.Map<ValidCheckinRes>(validVisitDetail);
            result.CardRes = _mapper.Map<CardRes>(qrCard);
            return result;
        }

        public async Task<Result<ValidCheckinRes>> ValidCheckWithoutCredentialCardIn(ValidCheckInCommand command)
        {
            var card = (await _cardRepo.FindAsync(
                    s => s.CardVerification == command.QRCardVerification && s.CardStatus.Equals(CardStatusEnum.Active.ToString())
                )).FirstOrDefault();
            if (card == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundCard);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                    s => s.CardId == card.CardId
                    && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString())
                    && s.ExpiryDate.Date >= DateTime.Now.Date
                )).FirstOrDefault();
            if (visitCard == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundVisitCard);
            }

            var visitDetails = await _visitDetailRepo.FindAsync(
                   s => s.VisitDetailId == visitCard.VisitDetailId
                   /*&& s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date*/
                   /*&& s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date*/,
                   int.MaxValue, 1, includeProperties: "Visit.ScheduleUser.Schedule.ScheduleType,Visitor"
                );
            var validVisitDetail = visitDetails.FirstOrDefault(visitDetail => IsValidVisit(visitDetail.Visit, DateTime.Now));
            if (validVisitDetail == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundVisitByCredentialCard);
            }

            //Check session don't have checkin
            var visitSesson = (await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetailId == validVisitDetail.VisitDetailId && s.Status == SessionStatus.CheckIn.ToString(),
                  1, 1
              )).FirstOrDefault();
            if (visitSesson != null)
            {
                return Result.Failure<ValidCheckinRes>(Error.ValidSession);
            }

            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = null;
            try
            {
                detectShoeResult = await _qrCodeService.DetectShoe(command.ImageShoe);
                if (!detectShoeResult.Value.Label.Equals("Shoe"))
                {
                    return Result.Failure<ValidCheckinRes>(Error.NotShoe);
                }
                if (detectShoeResult.IsFailure)
                {
                    return Result.Failure<ValidCheckinRes>(detectShoeResult.Error);
                }
            }
            catch (Exception ex)
            {
                return Result.Failure<ValidCheckinRes>(Error.DetectionExeption);
            }
            var result = _mapper.Map<ValidCheckinRes>(validVisitDetail);
            result.CardRes = _mapper.Map<CardRes>(card);
            return result;
        }
        public async Task<Result<GetVisitByCredentialCardRes>> ValidCheckIn(ValidCheckInCommand command)
        {
            /*if (command.VisitDetailId != 0)
            {
                var visitDetailCheck = (await _visitDetailRepo.FindAsync(s => *//*s.VisitDetailId == command.VisitDetailId*//*true, includeProperties: "Visit")).FirstOrDefault();
                if (visitDetailCheck == null)
                {
                    return Result.Failure<GetVisitByCredentialCardRes>(Error.NotFoundVisit);
                }

            }*/
            var qrCard = (await _cardRepo.FindAsync(
               s => s.CardVerification.Equals(command.QRCardVerification)))
               .FirstOrDefault();
            if (qrCard == null)
            {
                return Result.Failure<GetVisitByCredentialCardRes>(Error.NotFoundCard);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                               s => (s.CardId == qrCard.CardId)
                               && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString()),
                               includeProperties: "VisitDetail.Visit.ScheduleUser.Schedule.ScheduleType,VisitDetail.Visitor"
                                              )).FirstOrDefault();
            if (visitCard != null && visitCard.CardId == qrCard.CardId)
            {
                return Result.Failure<GetVisitByCredentialCardRes>(Error.DuplicateCard);
            }
            //if (visitCard != null && visitCard.VisitDetailId == command.VisitDetailId)
            //{
            //    return Result.Failure<GetVisitByCredentialCardRes>(Error.DuplicateVisitDetail);
            //}

            var visitSesson = (await _visitorSessionRepo.FindAsync(
                   s => /*s.VisitDetailId == command.VisitDetailId &&*/ s.Status == SessionStatus.CheckIn.ToString(),
                   1, 1
               )).FirstOrDefault();
            if (visitSesson != null)
            {
                return Result.Failure<GetVisitByCredentialCardRes>(Error.ValidSession);
            }
            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = null;
            try
            {
                detectShoeResult = await _qrCodeService.DetectShoe(command.ImageShoe);
                if (!detectShoeResult.Value.Label.Equals("Shoe"))
                {
                    return Result.Failure<GetVisitByCredentialCardRes>(Error.NotShoe);
                }
                if (detectShoeResult.IsFailure)
                {
                    return Result.Failure<GetVisitByCredentialCardRes>(detectShoeResult.Error);
                }
            }
            catch (Exception ex)
            {
                return Result.Failure<GetVisitByCredentialCardRes>(Error.DetectionExeption);
            }
            var visitResult = new VisitDetail();
            if (visitCard != null)
            {
                if (IsValidVisit(visitCard.VisitDetail.Visit, DateTime.Now))
                {
                    visitResult = visitCard.VisitDetail;
                }

            }
            else
            {
                visitResult = (await _visitDetailRepo.FindAsync(
               s => /*s.VisitDetailId == command.VisitDetailId
                &&*/ s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date
               && s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date,
               int.MaxValue, 1, s => s.OrderByDescending(s => s.ExpectedStartHour), "Visit.ScheduleUser.Schedule.ScheduleType,Visitor"
               )).FirstOrDefault();
            }
            var result = _mapper.Map<GetVisitByCredentialCardRes>(visitResult);

            //var result = new CheckInRes()
            //{
            //    VisitDetailId = visitCard.VisitDetailId,
            //    SecurityInId = visitSesson.SecurityInId,
            //    GateInId = visitSesson.GateInId,
            //    Card = _mapper.Map<GetCardRes>(qrCard),
            //    SessionsImageRes = _mapper.Map<SessionsRes>(checkinSession.Value),
            //    DetectShoeRes = detectShoeResult.Value,
            //};
            return result;
        }
        private bool IsValidVisit(Visit visit, DateTime date)
        {
            if (visit.ScheduleUser == null && visit.ExpectedStartTime.Date == DateTime.Now.Date)
            {
                return true;
            }
            else
            {
                string[] daysOfSchedule = visit.ScheduleUser.Schedule.DaysOfSchedule.Split(',');
                int dateOfWeekInput = ((int)date.DayOfWeek == 0) ? 7 : (int)date.DayOfWeek;
                if (visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessWeek.ToString())
                    && daysOfSchedule.Contains(dateOfWeekInput.ToString()))
                {
                    return true;
                }
                if (visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessMonth.ToString())
                    && daysOfSchedule.Contains(date.Day.ToString()))
                {
                    return true;
                }
                return false;
            }
        }
        async Task<Result<ICollection<GetVisitorSessionGraphQLRes>>> IVisitorSessionService.GetAllVisitorSessionGraphQL(int pageNumber, int pageSize, string token)
        {
            var userAuthor = _jwt.DecodeAuthorJwt(token);
            var visitSession = new List<VisitorSession>();
            if (userAuthor.Role == UserRoleEnum.Admin.ToString() || userAuthor.Role == UserRoleEnum.Manager.ToString())
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => true,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visit.ScheduleUser.Schedule,VisitDetail.Visitor"
                     )).ToList();
            }
            if (userAuthor.Role == UserRoleEnum.DepartmentManager.ToString())
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.CreateBy.DepartmentId == userAuthor.DepartmentId,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visit.ScheduleUser.Schedule,VisitDetail.Visitor"
                     )).ToList();
            }
            if (userAuthor.Role == UserRoleEnum.Staff.ToString())
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.ResponsiblePersonId == userAuthor.UserId,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visit.ScheduleUser.Schedule,VisitDetail.Visitor"
                     )).ToList();
            }

            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionGraphQLRes>>(Error.NotFoundVisitSesson);
            }
            var result = _mapper.Map<List<GetVisitorSessionGraphQLRes>>(visitSession);
            //var check = _mapper.Map<List<GraphQlVisitorRes>>(visitSession.Select(s => s.VisitDetail.Visitor));
            return result.ToList();
        }
        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetVisitorSessionByDate(int pageNumber, int pageSize, DateTime date, string token)
        {
            var userAuthor = _jwt.DecodeAuthorJwt(token);
            var visitSession = new List<VisitorSession>();
            if (userAuthor.Role == "Admin" || userAuthor.Role == "Manager")
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.CheckinTime.Date == DateTime.Now.Date,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                     )).ToList();
            }
            if (userAuthor.Role == "Department")
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.CreateBy.DepartmentId == userAuthor.DepartmentId
                         && s.CheckinTime.Date == DateTime.Now.Date,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                     )).ToList();
            }
            if (userAuthor.Role == "Staff")
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.ResponsiblePersonId == userAuthor.UserId
                         /*&& s.CheckinTime.Date == DateTime.Now.Date*/,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                     )).ToList();
            }

            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
            }
            var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
            return result.ToList();
        }

        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSession(int pageNumber, int pageSize, string token)
        {
            var userAuthor = _jwt.DecodeAuthorJwt(token);
            var visitSession = new List<VisitorSession>();
            if (userAuthor.Role == "Admin" || userAuthor.Role == "Manager")
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => true,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visitor"
                     )).ToList();
            }
            if (userAuthor.Role == "Department")
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.CreateBy.DepartmentId == userAuthor.DepartmentId,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visitor"
                     )).ToList();
            }
            if (userAuthor.Role == "Staff")
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.ResponsiblePersonId == userAuthor.UserId,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visitor"
                     )).ToList();
            }

            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
            }
            var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
            return result.ToList();
        }

        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSessionByVisitorId(int pageNumber, int pageSize, int visitorId)
        {
            var visitSession = await _visitorSessionRepo.FindAsync(
                    s => s.VisitDetail.VisitorId == visitorId,
                    pageSize, pageNumber,
                    orderBy: s => s.OrderBy(s => s.CheckinTime),
                    includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                );
            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
            }
            var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
            return result.ToList();
        }

        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSessionByVisitId(int pageNumber, int pageSize, int visitId)
        {
            var visitSession = await _visitorSessionRepo.FindAsync(
                 s => s.VisitDetail.VisitId == visitId,
                   pageSize, pageNumber,
                   orderBy: s => s.OrderBy(s => s.CheckinTime),
                   includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
               );
            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
            }
            var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
            return result.ToList();
        }

        public async Task<Result<SessionCheckOutRes>> GetVisitSessionStatusCheckInByCardVerification(string cardVerified)
        {
            var card = (await _cardRepo.FindAsync(
                    s => s.CardVerification == cardVerified && s.CardStatus == CardStatusEnum.Active.ToString()
                )).FirstOrDefault();
            if (card == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.NotFoundCard);
            }

            var visitCard = (await _visitCardRepo.FindAsync(
                s => s.CardId == card.CardId && s.VisitCardStatus == VisitCardStatusEnum.Issue.ToString()
                )).FirstOrDefault();

            if (visitCard == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CardNotIssue);
            }


            var visitSession = (await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetailId == visitCard.VisitDetailId
                  && s.Status == SessionStatus.CheckIn.ToString(),
                  int.MaxValue, 1,
                    includeProperties: "SecurityIn,GateIn,VisitDetail"
                )).FirstOrDefault();

            if (visitSession == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CheckoutNotValid);

            }

            var result = _mapper.Map<SessionCheckOutRes>(visitSession);
            result.VisitCard = _mapper.Map<VisitCardRes>(visitCard);

            return result;
        }

        public async Task<Result<SessionCheckOutRes>> GetVisitorSessionStatusCheckInByCredentialIdId(string credentialId)
        {
            var visitor = (await _visitorRepo.FindAsync(
                    s => s.CredentialsCard == credentialId && s.Status == VisitorStatusEnum.Active.ToString()
                )).FirstOrDefault();

            if (visitor == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.NotFoundVisitor);

            }


            var visitSession = (await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetail.VisitorId == visitor.VisitorId
                  && s.Status == SessionStatus.CheckIn.ToString(),
                    includeProperties: "SecurityIn,GateIn,VisitDetail"
                )).FirstOrDefault();

            if (visitSession == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CheckoutNotValid);
            }

            var visitCard = (await _visitCardRepo.FindAsync(
                    s => s.VisitDetailId == visitSession.VisitDetailId
                    && s.VisitCardStatus == VisitCardStatusEnum.Issue.ToString(),
                    includeProperties: "Card"
                )).FirstOrDefault();

            if (visitCard == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CardNotIssue);
            }


            var result = _mapper.Map<SessionCheckOutRes>(visitSession);
            result.VisitCard = _mapper.Map<VisitCardRes>(visitCard);
            return result;
        }
        public async Task<Result<SessionCheckOutRes>> CheckOutWithCard(VisitorSessionCheckOutCommand command, string qrCardVerifi)
        {
            var card = (await _cardRepo.FindAsync(
                s => s.CardVerification.Equals(qrCardVerifi)
                && s.CardStatus == CardStatusEnum.Active.ToString(),
                includeProperties: "CardType"
                )).FirstOrDefault();
            if (card == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.NotFoundCardByCardVerification);
            }

            var visitCard = (await _visitCardRepo.FindAsync(
                               s => s.CardId == card.CardId
                               && s.VisitCardStatus == VisitCardStatusEnum.Issue.ToString()
                                              )).FirstOrDefault();
            if (visitCard == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.NotFoundVisitCard);
            }


            var visitSession = (await _visitorSessionRepo.FindAsync(
                    s => s.VisitDetailId == visitCard.VisitDetailId && s.Status == SessionStatus.CheckIn.ToString(),
                    1, 1,
                includeProperties: "VisitDetail.Visitor, VisitDetail.Visit"
                )).FirstOrDefault();
            if (visitSession == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CheckoutNotValid);
            }
            if (visitSession != null && visitSession.VisitDetail.Visit.VisitStatus == VisitStatusEnum.ActiveTemporary.ToString())
            {
                return Result.Failure<SessionCheckOutRes>(Error.CheckoutNotValid);
            }

            //Check if schedule type is daily then cancel
            if (card.CardType.CardTypeName.Equals(CardTypeEnum.ShotTermCard.ToString()))
            {
                visitCard.UpdateVisitCardStatus(VisitCardStatusEnum.Expired.ToString());
                await _visitCardRepo.UpdateAsync(visitCard);
            }

            //Vehicle checkout
            if(command.VehicleSession != null)
            {
                var vehicleSession = (await _vehicleSessionRepo.FindAsync(
                       s => s.LicensePlate == command.VehicleSession.LicensePlate && s.Status == SessionStatus.CheckIn.ToString()
                   )).FirstOrDefault();
                if (vehicleSession == null)
                {
                    return Result.Failure<SessionCheckOutRes>(Error.ValidVehicleSessionCheckOut);
                }
                var vehicleSessionCheckout = vehicleSession.CheckOut(command.SecurityOutId, command.GateOutId, command.VehicleSession.VehicleImages.Select(i => (i.ImageType, i.ImageURL)).ToList());
                if (vehicleSessionCheckout.IsFailure)
                {
                    return Result.Failure<SessionCheckOutRes>(vehicleSessionCheckout.Error);
                }
                await _vehicleSessionRepo.UpdateAsync(vehicleSessionCheckout.Value);
            }


            command.Status = "CheckOut";
            command.CheckoutTime = DateTime.Now;
            var updateVisitorSesson = _mapper.Map(command, visitSession);
            await _visitorSessionRepo.UpdateAsync(updateVisitorSesson);
            await _unitOfWork.CommitAsync();



            //Noti
            var user = visitSession.VisitDetail.Visitor;
            var noti = Notification.Create($"Check-out từ chuyến thăm, Khách: {user.VisitorName}  ", $"Khách {user.VisitorName} đã Check-out", visitSession.VisitDetail.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
            noti.Value.AddUserNoti(command.SecurityOutId, (int)visitSession.VisitDetail.Visit.ResponsiblePersonId);
            await _notificationRepo.AddAsync(noti.Value);
            var commit2 = await _unitOfWork.CommitAsync();
            if (!commit2)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CommitError);
            }
            await _notifications.SendMessageAssignForStaff("New visit", "Temporary Visit", (int)visitSession.VisitDetail.Visit.ResponsiblePersonId, 1);
            

            var result = _mapper.Map<SessionCheckOutRes>(visitSession);
            result.VisitCard = _mapper.Map<VisitCardRes>(visitCard);

            return result;
        }
        public async Task<Result<SessionCheckOutRes>> CheckOutWithCredentialCard(VisitorSessionCheckOutCommand command, string credentialCard)
        {
            var visitor = (await _visitorRepo.FindAsync(
                    s => s.CredentialsCard == credentialCard && s.Status == VisitorStatusEnum.Active.ToString()
                )).FirstOrDefault();

            if (visitor == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.NotFoundVisitor);

            }


            var visitSession = (await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetail.VisitorId == visitor.VisitorId
                  && s.Status == SessionStatus.CheckIn.ToString(),
                    includeProperties: "SecurityIn,GateIn,VisitDetail.Visitor,VisitDetail.Visit"
                )).FirstOrDefault();

            if (visitSession == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CheckoutNotValid);
            }


            var visitCard = (await _visitCardRepo.FindAsync(
                               s => s.VisitDetailId == visitSession.VisitDetailId
                               && s.VisitCardStatus == VisitCardStatusEnum.Issue.ToString(),
                               includeProperties: "Card"
                                              )).FirstOrDefault();
            if (visitCard == null)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CardNotIssue);
            }



            visitCard.CancelCardLost();
            await _visitCardRepo.UpdateAsync(visitCard);

            command.Status = "CheckOut";
            command.CheckoutTime = DateTime.Now;
            var updateVisitorSesson = _mapper.Map(command, visitSession);
            await _visitorSessionRepo.UpdateAsync(updateVisitorSesson);
            await _unitOfWork.CommitAsync();

            //noti
            var user = visitor;
            var noti = Notification.Create($"Check-out từ chuyến thăm, Khách: {user.VisitorName}  ", $"Khách {user.VisitorName} đã Check-out", visitSession.VisitDetail.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
            noti.Value.AddUserNoti(command.SecurityOutId, (int)visitSession.VisitDetail.Visit.ResponsiblePersonId);
            await _notificationRepo.AddAsync(noti.Value);
            var commit2 = await _unitOfWork.CommitAsync();
            if (!commit2)
            {
                return Result.Failure<SessionCheckOutRes>(Error.CommitError);
            }
            await _notifications.SendMessageAssignForStaff("New visit", "Temporary Visit", (int)visitSession.VisitDetail.Visit.ResponsiblePersonId, 1);

            return null;
        }
        public async Task<Result<List<VisitorSessionImageRes>>> GetAllImagesByVisitorSessionId(int visitorSessionId)
        {
            var images = await _visitorSessionImagesRepo.FindAsync(s => s.VisitorSessionId == visitorSessionId, int.MaxValue, 1);
            if (images == null)
            {
                return Result.Failure<List<VisitorSessionImageRes>>(Error.NotFoundImage);
            }
            var result = _mapper.Map<List<VisitorSessionImageRes>>(images);
            return result;
        }




    }
}
