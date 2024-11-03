using AutoMapper;
using Azure.Core;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
using SecurityGateApv.Domain.Interfaces.Jwt;
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
        private readonly ICardRepo _qRCardRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVisitDetailRepo _visitDetailRepo;
        private readonly IVisitCardRepo _visitCardRepo;
        private readonly ICardService _qrCodeService;
        private readonly IVisitorRepo _visitorRepo;
        private readonly IJwt _jwt;

        public VisitorSessionService(IVisitorSessionRepo visitorSessionRepo, IMapper mapper, IUnitOfWork unitOfWork, ICardRepo qRCardRepo, IVisitDetailRepo visitDetailRepo, IVisitCardRepo visitCardRepo, ICardService cardService, IJwt jwt, IVisitorRepo visitorRepo)
        {
            _visitorSessionRepo = visitorSessionRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _qRCardRepo = qRCardRepo;
            _visitDetailRepo = visitDetailRepo;
            _visitCardRepo = visitCardRepo;
            _qrCodeService = cardService;
            _jwt = jwt;
            _visitorRepo = visitorRepo;
        }
        public async Task<Result<bool>> CheckOut(VisitorSessionCheckOutCommand command, string qrCardVerifi)
        {
            var qRCard = (await _qRCardRepo.FindAsync(
                s => s.CardVerification.Equals(qrCardVerifi),
                includeProperties: "CardType"
                )).FirstOrDefault();
            if (qRCard == null)
            {
                return Result.Failure<bool>(Error.NotFoundCardById);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                               s => s.CardId == qRCard.CardId
                               && s.VisitCardStatus == VisitCardStatusEnum.Issue.ToString()
                                              )).FirstOrDefault();
            if (visitCard == null)
            {
                return Result.Failure<bool>(Error.NotFoundVisitCard);
            }


            var visitSesson = (await _visitorSessionRepo.FindAsync(
                    s => s.VisitDetailId == visitCard.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
                    1, 1
                //includeProperties: "VisitDetail.Visit.Schedule"
                )).FirstOrDefault();
            //Check if schedule type is daily then cancel
            if (qRCard.CardType.CardTypeName.Equals(CardTypeEnum.ShotTermCard.ToString()))
            {
                visitCard.UpdateVisitCardStatus(VisitCardStatusEnum.Expired.ToString());
                await _visitCardRepo.UpdateAsync(visitCard);
            }
            if (visitSesson == null)
            {
                return Result.Failure<bool>(Error.NotFoundVisitSessonByQRId);
            }
            //qRCard.UpdateQRCardStatus(2);
            //await _qRCardRepo.UpdateAsync(qRCard);

            command.Status = "CheckOut";
            command.CheckoutTime = DateTime.Now;
            var updateVisitorSesson = _mapper.Map(command, visitSesson);
            await _visitorSessionRepo.UpdateAsync(updateVisitorSesson);
            await _unitOfWork.CommitAsync();
            return true;
        }
        public async Task<Result<CheckInRes>> CheckInWithCredentialCard(VisitSessionCheckInCommand command)
        {
            var visitDetails = await _visitDetailRepo.FindAsync(
                s => s.Visitor.CredentialsCard.Equals(command.CredentialCard)
                /*&& s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date*/
                && s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date
                && s.ExpectedStartHour <= DateTime.Now.TimeOfDay
                && s.ExpectedEndHour >= DateTime.Now.TimeOfDay,
                int.MaxValue, 1, includeProperties: "Visit.Schedule.ScheduleType,Visitor"
            );
            var validVisitDetail = visitDetails.FirstOrDefault(visitDetail => IsValidVisit(visitDetail.Visit, DateTime.Now));
            if (validVisitDetail == null)
            {
                return Result.Failure<CheckInRes>(Error.NotFoundVisitByCredentialCard);
            }

            // Check exist Card and does not have visit
            var qrCard = (await _qRCardRepo.FindAsync(
                s => s.CardVerification.Equals(command.QRCardVerification),
                includeProperties: "CardType"
                ))
                .FirstOrDefault();
            if (qrCard == null)
            {
                return Result.Failure<CheckInRes>(Error.NotFoundCard);
            }

            // Check valid CredentialCard and Card 
            var visitCard = (await _visitCardRepo.FindAsync(
                s => (s.CardId == qrCard.CardId && s.VisitDetailId == validVisitDetail.VisitDetailId)
                && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString())
            )).FirstOrDefault();
            if (visitCard != null && visitCard.CardId != qrCard.CardId)
            {
                return Result.Failure<CheckInRes>(Error.DuplicateCard);
            }
            if (visitCard != null && visitCard.VisitDetailId != validVisitDetail.VisitDetailId)
            {
                return Result.Failure<CheckInRes>(Error.DuplicateVisitDetail);
            }

            // Check session don't have check-in
            var visitSession = (await _visitorSessionRepo.FindAsync(
                s => s.VisitDetailId == validVisitDetail.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
                1, 1
            )).FirstOrDefault();
            if (visitSession != null)
            {
                return Result.Failure<CheckInRes>(Error.ValidSession);
            }

            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = Result.Success<AWSDomainDTO>(null);
            try
            {
                var shoeImage = command.Images.FirstOrDefault(s => s.ImageType == "Shoe");
                if (shoeImage == null)
                {
                    return Result.Failure<CheckInRes>(Error.NotShoe);
                }

                detectShoeResult = await _qrCodeService.DetectShoe(shoeImage.Image);
                if (!detectShoeResult.Value.Label.Equals("Shoe"))
                {
                    return Result.Failure<CheckInRes>(Error.NotShoe);
                }
                if (detectShoeResult.IsFailure)
                {
                    return Result.Failure<CheckInRes>(detectShoeResult.Error);
                }
            }
            catch
            {
                return Result.Failure<CheckInRes>(Error.DetectionExeption);
            }

            //var result = _mapper.Map<CheckInRes>(validVisitDetail);
            //result.CardRes = _mapper.Map<CardRes>(qrCard);


            if (visitCard == null)
            {
                if ((validVisitDetail.Visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName == ScheduleTypeEnum.VisitDaily.ToString()
                    && qrCard.CardType.CardTypeName == CardTypeEnum.ShotTermCard.ToString()))
                {
                    visitCard = VisitCard.Create(DateTime.Now, validVisitDetail.Visit.ExpectedEndTime, "Issue", validVisitDetail.VisitDetailId, qrCard.CardId);
                }
                else if (qrCard.CardType.CardTypeName == CardTypeEnum.LongTermCard.ToString()
                    && validVisitDetail.Visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName != ScheduleTypeEnum.VisitDaily.ToString()
                    )
                {
                    visitCard = VisitCard.Create(DateTime.Now, validVisitDetail.Visit.ExpectedEndTime, "Issue", validVisitDetail.VisitDetailId, qrCard.CardId);
                }
                else
                {
                    var error = Error.ScheduleAndCardTypeMismatch(validVisitDetail.Visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName, qrCard.CardType.CardTypeName);
                    return Result.Failure<CheckInRes>(error);
                }
                await _visitCardRepo.AddAsync(visitCard);
            }


            var checkinSession = VisitorSession.Checkin(validVisitDetail.VisitDetailId, command.SecurityInId, command.GateInId);
            if (checkinSession.IsFailure)
            {
                return Result.Failure<CheckInRes>(checkinSession.Error);
            }
            var session = checkinSession.Value;

            foreach (var item in command.Images)
            {
                session.AddVisitorImage(item.ImageType, item.ImageURL);
            }
            var result = new CheckInRes()
            {
                VisitDetailId = validVisitDetail.VisitDetailId,
                SecurityInId = command.SecurityInId,
                GateInId = command.GateInId,
                Card = _mapper.Map<GetCardRes>(qrCard),
                SessionsImageRes = _mapper.Map<SessionsRes>(checkinSession.Value),
                DetectShoeRes = detectShoeResult.Value,
            };
            await _visitorSessionRepo.AddAsync(checkinSession.Value);
            if (!await _unitOfWork.CommitAsync())
            {
                return Result.Failure<CheckInRes>(Error.CheckInFail);
            };


            return result;
        }

        public async Task<Result<CheckInRes>> CheckInWithoutCredentialCard(VisitSessionCheckInCommand command)
        {
            var card = (await _qRCardRepo.FindAsync(
                    s => s.CardVerification == command.QRCardVerification && s.CardStatus.Equals(CardStatusEnum.Active.ToString())
                )).FirstOrDefault();
            if (card == null)
            {
                return Result.Failure<CheckInRes>(Error.NotFoundCard);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                    s => s.CardId == card.CardId
                    && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString())
                    && s.ExpiryDate.Date >= DateTime.Now.Date
                )).FirstOrDefault();
            if (visitCard == null)
            {
                return Result.Failure<CheckInRes>(Error.NotFoundVisitCard);
            }

            var visitDetails = await _visitDetailRepo.FindAsync(
                   s => s.VisitDetailId == visitCard.VisitDetailId
                   /*&& s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date*/
                   /*&& s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date*/,
                   int.MaxValue, 1, includeProperties: "Visit.Schedule.ScheduleType,Visitor"
                );
            var validVisitDetail = visitDetails.FirstOrDefault(visitDetail => IsValidVisit(visitDetail.Visit, DateTime.Now));
            if (validVisitDetail == null)
            {
                return Result.Failure<CheckInRes>(Error.NotFoundVisitByCredentialCard);
            }

            //Check session don't have checkin
            var visitSesson = (await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetailId == validVisitDetail.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
                  1, 1
              )).FirstOrDefault();
            if (visitSesson != null)
            {
                return Result.Failure<CheckInRes>(Error.ValidSession);
            }

            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = Result.Success<AWSDomainDTO>(null);
            try
            {
                var shoeImage = command.Images.FirstOrDefault(s => s.ImageType == "Shoe");
                if (shoeImage == null)
                {
                    return Result.Failure<CheckInRes>(Error.NotShoe);
                }

                detectShoeResult = await _qrCodeService.DetectShoe(shoeImage.Image);
                if (!detectShoeResult.Value.Label.Equals("Shoe"))
                {
                    return Result.Failure<CheckInRes>(Error.NotShoe);
                }
                if (detectShoeResult.IsFailure)
                {
                    return Result.Failure<CheckInRes>(detectShoeResult.Error);
                }
            }
            catch
            {
                return Result.Failure<CheckInRes>(Error.DetectionExeption);
            }



            var checkinSession = VisitorSession.Checkin(validVisitDetail.VisitDetailId, command.SecurityInId, command.GateInId);
            if (checkinSession.IsFailure)
            {
                return Result.Failure<CheckInRes>(checkinSession.Error);
            }
            var session = checkinSession.Value;

            foreach (var item in command.Images)
            {
                session.AddVisitorImage(item.ImageType, item.ImageURL);
            }
            var result = new CheckInRes()
            {
                VisitDetailId = validVisitDetail.VisitDetailId,
                SecurityInId = command.SecurityInId,
                GateInId = command.GateInId,
                Card = _mapper.Map<GetCardRes>(card),
                SessionsImageRes = _mapper.Map<SessionsRes>(checkinSession.Value),
                DetectShoeRes = detectShoeResult.Value,
            };
            await _visitorSessionRepo.AddAsync(checkinSession.Value);
            if (!await _unitOfWork.CommitAsync())
            {
                return Result.Failure<CheckInRes>(Error.CheckInFail);
            };


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
               int.MaxValue, 1, includeProperties: "Visit.Schedule.ScheduleType,Visitor"
               );
            var validVisitDetail = visitDetails.FirstOrDefault(visitDetail => IsValidVisit(visitDetail.Visit, DateTime.Now));
            if (validVisitDetail == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundVisitByCredentialCard);
            }

            //Check exsit Card and dos not have visit
            var qrCard = (await _qRCardRepo.FindAsync(
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
                  s => s.VisitDetailId == validVisitDetail.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
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
            var card = (await _qRCardRepo.FindAsync(
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
                   int.MaxValue, 1, includeProperties: "Visit.Schedule.ScheduleType,Visitor"
                );
            var validVisitDetail = visitDetails.FirstOrDefault(visitDetail => IsValidVisit(visitDetail.Visit, DateTime.Now));
            if (validVisitDetail == null)
            {
                return Result.Failure<ValidCheckinRes>(Error.NotFoundVisitByCredentialCard);
            }

            //Check session don't have checkin
            var visitSesson = (await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetailId == validVisitDetail.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
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
            var qrCard = (await _qRCardRepo.FindAsync(
               s => s.CardVerification.Equals(command.QRCardVerification)))
               .FirstOrDefault();
            if (qrCard == null)
            {
                return Result.Failure<GetVisitByCredentialCardRes>(Error.NotFoundCard);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                               s => (s.CardId == qrCard.CardId)
                               && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString()),
                               includeProperties: "VisitDetail.Visit.Schedule.ScheduleType,VisitDetail.Visitor"
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
                   s => /*s.VisitDetailId == command.VisitDetailId &&*/ s.Status == VisitorSessionStatus.CheckIn.ToString(),
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
               int.MaxValue, 1, s => s.OrderByDescending(s => s.ExpectedStartHour), "Visit.Schedule.ScheduleType,Visitor"
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
            string[] daysOfSchedule = visit.ScheduleUser.Schedule.DaysOfSchedule.Split(',');
            int dateOfWeekInput = ((int)date.DayOfWeek == 0) ? 7 : (int)date.DayOfWeek;
            if (visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.VisitDaily.ToString()) && visit.ExpectedStartTime.Date == DateTime.Now.Date)
            {
                return true;
            }
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
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visit.Schedule,VisitDetail.Visitor"
                     )).ToList();
            }
            if (userAuthor.Role == UserRoleEnum.DepartmentManager.ToString())
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.CreateBy.DepartmentId == userAuthor.DepartmentId,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visit.Schedule,VisitDetail.Visitor"
                     )).ToList();
            }
            if (userAuthor.Role == UserRoleEnum.Staff.ToString())
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.ResponsiblePersonId == userAuthor.UserId,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images,VisitDetail.Visit.Schedule,VisitDetail.Visitor"
                     )).ToList();
            }

            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionGraphQLRes>>(Error.NotFoundVisitSesson);
            }
            var result = _mapper.Map<List<GetVisitorSessionGraphQLRes>>(visitSession);
            var check = _mapper.Map<List<GraphQlVisitorRes>>(visitSession.Select(s => s.VisitDetail.Visitor));
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
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                     )).ToList();
            }
            if (userAuthor.Role == "Department")
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.CreateBy.DepartmentId == userAuthor.DepartmentId,
                         pageSize, pageNumber,
                         orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                         includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                     )).ToList();
            }
            if (userAuthor.Role == "Staff")
            {
                visitSession = (await _visitorSessionRepo.FindAsync(
                         s => s.VisitDetail.Visit.ResponsiblePersonId == userAuthor.UserId,
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

        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetVisitSessionStatusCheckInByCardVerification(string cardVerified)
        {

            var visitSession = await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetail.VisitCard.Any(s => s.Card.CardVerification == cardVerified && s.VisitCardStatus.Equals(VisitCardStatusEnum.Issue.ToString())),
                  int.MaxValue, 1,
                    includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                );
            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.CardNotIssue);
            }
            foreach (var item in visitSession)
            {
                if (item.Status == VisitorSessionStatus.CheckIn.ToString())
                {
                    var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
                    return result.ToList();
                }
            }
            return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.CardNotCheckIn);
        }

        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSessionStatusCheckInByCredentialIdId(string credentialId)
        {
            var visitSession = await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetail.Visitor.CredentialsCard.Equals(credentialId),
                   int.MaxValue, 1,
                    includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                );
            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
            }
            foreach (var item in visitSession)
            {
                if (item.Status == VisitorSessionStatus.CheckIn.ToString())
                {
                    var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
                    return result.ToList();
                }
            }
            return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.CardNotCheckIn);
        }


    }
}
