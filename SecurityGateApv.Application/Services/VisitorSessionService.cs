using AutoMapper;
using Azure.Core;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
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

        public VisitorSessionService(IVisitorSessionRepo visitorSessionRepo, IMapper mapper, IUnitOfWork unitOfWork, ICardRepo qRCardRepo, IVisitDetailRepo visitDetailRepo, IVisitCardRepo visitCardRepo, ICardService cardService)
        {
            _visitorSessionRepo = visitorSessionRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _qRCardRepo = qRCardRepo;
            _visitDetailRepo = visitDetailRepo;
            _visitCardRepo = visitCardRepo;
            _qrCodeService = cardService;
        }
        public async Task<Result<bool>> CheckOut(VisitorSessionCheckOutCommand command, string qrCardVerifi)
        {
            var qRCard = (await _qRCardRepo.FindAsync(
                s => s.CardVerification.Equals(qrCardVerifi)
                )).FirstOrDefault();
            if (qRCard == null)
            {
                return Result.Failure<bool>(Error.NotFoundCardById);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                               s => s.CardId == qRCard.CardId
                                              )).FirstOrDefault();
            if (visitCard == null)
            {
                return Result.Failure<bool>(Error.NotFoundVisitCard);
            }
            if (visitCard != null && visitCard.VisitCardStatus == VisitCardEnum.Expired.ToString())
            {
                return Result.Failure<bool>(Error.CardExpried);
            }


            var visitSesson = (await _visitorSessionRepo.FindAsync(
                    s => s.VisitDetailId == visitCard.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
                    1, 1
                )).FirstOrDefault();
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

        public async Task<Result<CheckInRes>> CheckIn(VisitSessionCheckInCommand command)
        {
            //check visit detail id is exist, visit detail not exist card, 
            var visitDetailCheck = (await _visitDetailRepo.FindAsync(s => s.VisitDetailId == command.VisitDetailId, includeProperties: "Visit")).FirstOrDefault();
            if (visitDetailCheck == null)
            {
                return Result.Failure<CheckInRes>(Error.NotFoundVisit);
            }
            var qrCard = (await _qRCardRepo.FindAsync(
               s => s.CardVerification.Equals(command.QRCardVerification)))
               .FirstOrDefault();
            if (qrCard == null)
            {
                return Result.Failure<CheckInRes>(Error.NotFoundCard);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                               s => (s.CardId == qrCard.CardId || s.VisitDetailId == command.VisitDetailId)
                               && s.VisitCardStatus.Equals(VisitCardEnum.Issue.ToString())
                                              )).FirstOrDefault();
            if (visitCard != null && visitCard.CardId == qrCard.CardId)
            {
                return Result.Failure<CheckInRes>(Error.DuplicateCard);
            }
            if (visitCard != null && visitCard.VisitDetailId == command.VisitDetailId)
            {
                return Result.Failure<CheckInRes>(Error.DuplicateVisitDetail);
            }

            var visitSesson = (await _visitorSessionRepo.FindAsync(
                   s => s.VisitDetailId == command.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
                   1, 1
               )).FirstOrDefault();
            if (visitSesson != null)
            {
                return Result.Failure<CheckInRes>(Error.ValidSession);
            }

            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = null;
            bool shoeImageFound = false;

            foreach (var item in command.Images)
            {
                if (item.ImageType == "Shoe")
                {
                    shoeImageFound = true;
                    try
                    {
                        detectShoeResult = await _qrCodeService.DetectShoe(item.Image);
                        if (detectShoeResult.IsFailure)
                        {
                            return Result.Failure<CheckInRes>(detectShoeResult.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        return Result.Failure<CheckInRes>(Error.DetectionExeption);
                    }
                }
            }
            if (!shoeImageFound)
            {
                return Result.Failure<CheckInRes>(Error.NotFoundShoeTypeImage);
            }



            //qrCard.UpdateQRCardStatus(1);
            //await _qRCardRepo.UpdateAsync(qrCard);

            if (visitCard == null)
            {
                visitCard = VisitCard.Create(DateTime.Now, visitDetailCheck.Visit.ExpectedEndTime, "Issue", command.VisitDetailId, qrCard.CardId);
                await _visitCardRepo.AddAsync(visitCard);
            }

            var checkinSession = VisitorSession.Checkin(command.VisitDetailId, command.SecurityInId, command.GateInId);
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
                VisitDetailId = command.VisitDetailId,
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
        public async Task<Result<bool>> ValidCheckIn(ValidCheckInCommand command)
        {
            var visitDetailCheck = (await _visitDetailRepo.FindAsync(s => s.VisitDetailId == command.VisitDetailId, includeProperties: "Visit")).FirstOrDefault();
            if (visitDetailCheck == null)
            {
                return Result.Failure<bool>(Error.NotFoundVisit);
            }
            var qrCard = (await _qRCardRepo.FindAsync(
               s => s.CardVerification.Equals(command.QRCardVerification)))
               .FirstOrDefault();
            if (qrCard == null)
            {
                return Result.Failure<bool>(Error.NotFoundCard);
            }
            var visitCard = (await _visitCardRepo.FindAsync(
                               s => (s.CardId == qrCard.CardId || s.VisitDetailId == command.VisitDetailId)
                               && s.VisitCardStatus.Equals(VisitCardEnum.Issue.ToString())
                                              )).FirstOrDefault();
            if (visitCard != null && visitCard.CardId == qrCard.CardId)
            {
                return Result.Failure<bool>(Error.DuplicateCard);
            }
            if (visitCard != null && visitCard.VisitDetailId == command.VisitDetailId)
            {
                return Result.Failure<bool>(Error.DuplicateVisitDetail);
            }

            var visitSesson = (await _visitorSessionRepo.FindAsync(
                   s => s.VisitDetailId == command.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
                   1, 1
               )).FirstOrDefault();
            if (visitSesson != null)
            {
                return Result.Failure<bool>(Error.ValidSession);
            }
            // Add Detect shoe
            Result<AWSDomainDTO> detectShoeResult = null;
            try
            {
                detectShoeResult = await _qrCodeService.DetectShoe(command.ImageShoe);
                if (!detectShoeResult.Value.Label.Equals("Shoe"))
                {
                    return Result.Failure<bool>(Error.NotShoe);
                }
                if (detectShoeResult.IsFailure)
                {
                    return Result.Failure<bool>(detectShoeResult.Error);
                }
            }
            catch (Exception ex)
            {
                return Result.Failure<bool>(Error.DetectionExeption);
            }
            return true;
        }

        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSession(int pageNumber, int pageSize)
        {
            var visitSession = await _visitorSessionRepo.FindAsync(
                    s => true,
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

        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetVisitSessionByQRCardVerification(string qrCardVerified)
        {
            //var visitSession = await _visitorSessionRepo.FindAsync(
            //      s => s.Card.CardVerification.Equals(qrCardVerified) && s.Status.Equals(VisitorSessionStatus.CheckIn.ToString()),
            //        includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
            //    );
            //if (visitSession.Count() == 0)
            //{
            //    return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
            //}
            //var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
            //return result.ToList();
            return null;
        }

        public async Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSessionByCredentialIdId(string credentialId)
        {
            var visitSession = await _visitorSessionRepo.FindAsync(
                  s => s.VisitDetail.Visitor.CredentialsCard.Equals(credentialId) && s.Status.Equals(VisitorSessionStatus.CheckIn.ToString()),
                    includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                );
            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
            }
            var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
            return result.ToList();
        }

    }
}
