using AutoMapper;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Common;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services
{
    public class VisitorService : IVisitorService
    {
        private readonly IVisitorRepo _visitorRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public VisitorService(IVisitorRepo visitorRepo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _visitorRepo = visitorRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<CreateVisitorCommand>> CreateVisitor(CreateVisitorCommand command)
        {
            var imageString = await CommonService.ImageToBase64(command.VisitorCredentialImageFromRequest);
            var imageEncrypt = await CommonService.Encrypt(imageString);
            var visitorCreate = Visitor.Create(
                command.VisitorName,
                command.CompanyName,
                command.PhoneNumber,
                DateTime.Now,
                DateTime.Now,
                command.CredentialsCard,
                imageEncrypt,
                "Active",
                command.CredentialCardTypeId
                );
            if (visitorCreate.IsFailure)
            {
                return Result.Failure<CreateVisitorCommand>(Error.CreateVisitor);
            }
            await _visitorRepo.AddAsync(visitorCreate.Value);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<CreateVisitorCommand>(Error.CommitError);
            }
            return command;
        }

        public async Task<Result<bool>> DeleteVisitor(int visitorId)
        {
            var visitor = (await _visitorRepo.FindAsync(s => s.VisitorId == visitorId)).FirstOrDefault();
            if (visitor == null)
            {
                return Result.Failure<bool>(Error.NotFoundVisitor);
            }
            visitor.Delete();
            await _visitorRepo.UpdateAsync(visitor);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<bool>(Error.CommitError);
            }
            return true;
        }

        public async Task<Result<List<GetVisitorRes>>> GetAllByPaging(int pageNumber, int pageSize)
        {
            var list = await _visitorRepo.FindAsync(s=> true, pageSize, pageNumber);
            if(list.Count() == 0)
            {
                return Result.Failure<List<GetVisitorRes>>(Error.NotFound);
            }
            return _mapper.Map<List<GetVisitorRes>>(list);
        }

        public async Task<Result<GetVisitorRes>> GetByCredentialCard(string cardNumber)
        {
            var visitor = (await _visitorRepo.FindAsync(s => s.CredentialsCard == cardNumber, includeProperties: "CredentialCardType")).FirstOrDefault();
            if (visitor == null)
            {
                return Result.Failure<GetVisitorRes>(Error.NotFound);
            }
            try
            {
                visitor.DecrypCredentialCard(await CommonService.Decrypt(visitor.VisitorCredentialImage));
            }
            catch (Exception ex)
            {
                return Result.Failure<GetVisitorRes>(Error.DecryptError);
            }
            return _mapper.Map<GetVisitorRes>(visitor);
        }

        public async Task<Result<GetVisitorRes>> GetById(int visitorId)
        {
            var visitor = (await _visitorRepo.FindAsync(s => s.VisitorId == visitorId, includeProperties: "CredentialCardType")).FirstOrDefault();
            if (visitor == null)
            {
                return Result.Failure<GetVisitorRes>(Error.NotFound);
            }
            try
            {
                visitor.DecrypCredentialCard(await CommonService.Decrypt(visitor.VisitorCredentialImage));
            }
            catch (Exception ex) {
                return Result.Failure<GetVisitorRes>(Error.DecryptError);
            }
            return _mapper.Map<GetVisitorRes>(visitor);
        }

        public async Task<Result<CreateVisitorCommand>> UpdateVisitor(int visitorId, CreateVisitorCommand command)
        {
            var visitor = (await _visitorRepo.FindAsync(s => s.VisitorId == visitorId)).FirstOrDefault();
            if (visitor == null)
            {
                return Result.Failure<CreateVisitorCommand>(Error.NotFound);
            }
            var imageString = await CommonService.ImageToBase64(command.VisitorCredentialImageFromRequest);
            var imageEncrypt = await CommonService.Encrypt(imageString);
            visitor = _mapper.Map(command, visitor);
            visitor.Update(imageEncrypt);
            await _visitorRepo.UpdateAsync(visitor);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<CreateVisitorCommand>(Error.CommitError);
            }
            return command;
        }
    }
}
