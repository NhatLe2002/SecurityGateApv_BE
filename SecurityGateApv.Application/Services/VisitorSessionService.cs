using AutoMapper;
using Azure.Core;
using SecurityGateApv.Application.DTOs.Req;
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
        public VisitorSessionService(IVisitorSessionRepo visitorSessionRepo, IMapper mapper, IUnitOfWork unitOfWork, IQRCardRepo qRCardRepo)
        {
            _visitorSessionRepo = visitorSessionRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _qRCardRepo = qRCardRepo;
        }
        public async Task<Result<bool>> CheckIn(VisitorSessionCheckOutCommand command, int qrCardId)
        {
            var qRCard = await _qRCardRepo.GetByIdAsync(qrCardId);
            if (qRCard == null)
            {
                return Result.Failure<bool>(Error.NotFoundQRCardById);
            }


            var visitSesson =  await _visitorSessionRepo.FindAsync(
                    s => s.QRCardId == qrCardId && s.Status == VisitorSessonStatus.CheckIn.ToString(),
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
    }
}
