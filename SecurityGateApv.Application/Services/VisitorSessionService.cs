using AutoMapper;
using Azure.Core;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
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
        private readonly IQRCardRepo _qRCardRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVisitDetailRepo _visitDetailRepo;
        public VisitorSessionService(IVisitorSessionRepo visitorSessionRepo, IMapper mapper, IUnitOfWork unitOfWork, IQRCardRepo qRCardRepo, IVisitDetailRepo visitDetailRepo)
        {
            _visitorSessionRepo = visitorSessionRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _qRCardRepo = qRCardRepo;
            _visitDetailRepo = visitDetailRepo;
        }
        public async Task<Result<bool>> CheckOut(VisitorSessionCheckOutCommand command, string qrCardVerifi)
        {
            var qRCard = (await _qRCardRepo.FindAsync(
                s => s.CardVerification.Equals(qrCardVerifi)
                ) ).FirstOrDefault();
            if (qRCard == null)
            {
                return Result.Failure<bool>(Error.NotFoundQRCardById);
            }
            if (qRCard.CardStatus.Equals(QrCardStatusEnum.Inactive.ToString()))
            {
                return Result.Failure<bool>(Error.CardInActive);
            }

            var visitSesson =  await _visitorSessionRepo.FindAsync(
                    s => s.Card.CardVerification.Equals( qrCardVerifi) && s.Status == VisitorSessionStatus.CheckIn.ToString(),
                    1,1
                );
            if (visitSesson.Count() == 0 )
            {
                return Result.Failure<bool>( Error.NotFoundVisitSessonByQRId);
            }
            qRCard.UpdateQRCardStatus(2);
            await _qRCardRepo.UpdateAsync(qRCard);

            command.Status = "CheckOut";
            var updateVisitorSesson = _mapper.Map(command, visitSesson.FirstOrDefault());
            await _visitorSessionRepo.UpdateAsync(updateVisitorSesson);
            await _unitOfWork.CommitAsync();
            return true;
        }

        public async Task<Result<bool>> CheckIn(VisitSessionCheckInCommand command)
        {
            var visitDetailCheck = await _visitDetailRepo.GetByIdAsync(command.VisitDetailId);
            if (visitDetailCheck == null)
            {
                return Result.Failure<bool>(Error.NotFoundVisit);
            }
            var visitSesson = (await _visitorSessionRepo.FindAsync(
                   s => s.VisitDetailId == command.VisitDetailId && s.Status == VisitorSessionStatus.CheckIn.ToString(),
                   1, 1
               )).FirstOrDefault();
            if (visitSesson != null)
            {
                return Result.Failure<bool>(Error.ValidSession);
            }
            var qrCard = (await _qRCardRepo.FindAsync(
               s => s.CardVerification.Equals(command.QRCardVerification)))
               .FirstOrDefault();

            if (qrCard == null)
            {
                return Result.Failure<bool>(Error.NotFoundQRCard);
            }
            if (qrCard.CardStatus.Equals(QrCardStatusEnum.Active.ToString()))
            {
                return Result.Failure<bool>(Error.CardAcctive);
            }
            qrCard.UpdateQRCardStatus(1);
            await _qRCardRepo.UpdateAsync(qrCard);



            var checkinSession =  VisitorSession.Checkin(qrCard.CardId, command.VisitDetailId, command.SecurityInId, command.GateInId);
            if (checkinSession.IsFailure)
            {
                return Result.Failure<bool>(checkinSession.Error);
            }
            var session = checkinSession.Value;

            foreach ( var item in command.Images)
            {
                session.AddVisitorImage(item.ImageType, item.ImageURL);
            }
            await _visitorSessionRepo.AddAsync(checkinSession.Value);
            await _unitOfWork.CommitAsync();
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
                return  Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
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
            var visitSession = await _visitorSessionRepo.FindAsync(
                  s => s.Card.CardVerification.Equals(qrCardVerified) && s.Status.Equals(VisitorSessionStatus.CheckIn.ToString()),
                    includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,Images"
                );
            if (visitSession.Count() == 0)
            {
                return Result.Failure<ICollection<GetVisitorSessionRes>>(Error.NotFoundVisitSesson);
            }
            var result = _mapper.Map<IEnumerable<GetVisitorSessionRes>>(visitSession);
            return result.ToList();
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
