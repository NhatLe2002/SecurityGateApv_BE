using AutoMapper;
using Microsoft.AspNetCore.Http;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Common;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Domain.Shared;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;
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
        public async Task<Result<GetVisitorCreateRes>> CreateVisitor(CreateVisitorCommand command)
        {
/*            SixLabors.ImageSharp.Image resizeImage = SixLabors.ImageSharp.Image.Load(command.VisitorCredentialImageFromRequest.OpenReadStream());
            int height = (int)((300 / (float)resizeImage.Width) * resizeImage.Height);
            if (resizeImage.Width > 300 || resizeImage.Height > 200)
            {
                resizeImage.Mutate(x => x.Resize(300, height));
            }
            var imageString = await ImageToBase64(resizeImage);*/
            var imageEncrypt = await CommonService.Encrypt(command.VisitorCredentialImageFromRequest);
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
                return Result.Failure<GetVisitorCreateRes>(Error.CreateVisitor);
            }
            await _visitorRepo.AddAsync(visitorCreate.Value);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<GetVisitorCreateRes>(Error.CommitError);
            }
            var res = _mapper.Map<GetVisitorCreateRes>(visitorCreate.Value);
            res.VisitorCredentialImage = command.VisitorCredentialImageFromRequest;
            return res;
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
            var list = await _visitorRepo.FindAsync(s=> true, pageSize, pageNumber, includeProperties: "CredentialCardType");
            if(list.Count() == 0)
            {
                return Result.Failure<List<GetVisitorRes>>(Error.NotFound);
            }
            foreach (var item in list) {
                try
                {
                    item.DecrypCredentialCard(await CommonService.Decrypt(item.VisitorCredentialImage));
                }
                catch (Exception ex)
                {
                    
                }
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

        public async Task<Result<GetVisitorCreateRes>> UpdateVisitor(int visitorId, UpdateVisitorCommand command)
        {
            var duplicateCard = await _visitorRepo.IsAny(s => s.CredentialsCard == command.CredentialsCard && s.CredentialCardTypeId == command.CredentialCardTypeId && s.VisitorId != visitorId);
            if (duplicateCard)
            {
                return Result.Failure<GetVisitorCreateRes>(Error.DuplicateCardNumber);
            }
            var visitor = (await _visitorRepo.FindAsync(s => s.VisitorId == visitorId)).FirstOrDefault();
            if (visitor == null)
            {
                return Result.Failure<GetVisitorCreateRes>(Error.NotFound);
            }
            var imageEncrypt = await CommonService.Encrypt(command.VisitorCredentialImageFromRequest);
            visitor = _mapper.Map(command, visitor);
            visitor.Update(imageEncrypt);
            await _visitorRepo.UpdateAsync(visitor);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<GetVisitorCreateRes>(Error.CommitError);
            }
            var res = _mapper.Map<GetVisitorCreateRes>(visitor);
            res.VisitorCredentialImage = command.VisitorCredentialImageFromRequest;
            return res;
        }
        private async Task<string> ImageToBase64(Image image)
        {
            var ms = new MemoryStream();
            await image.SaveAsync(ms, new PngEncoder());
            return System.Convert.ToBase64String(ms.ToArray());
        }
    }
}
