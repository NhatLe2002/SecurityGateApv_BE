using AutoMapper;
using Microsoft.AspNetCore.Http;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.AWS;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
using SecurityGateApv.Domain.Interfaces.ExtractImage;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Shared;
using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityGateApv.Application.DTOs.Req.CreateReq;

namespace SecurityGateApv.Application.Services
{
    public class CardService : ICardService
    {
        private readonly IExtractQRCode _extractQRCode;
        private readonly ICardRepo _qrRCardRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAWSService _awsService;
        private readonly IPrivateKeyRepo _privateKeyRepo;

        public CardService(IExtractQRCode extractQRCode, IMapper mapper, IUnitOfWork unitOfWork,
            IAWSService awsService, ICardRepo qrRCardRepo, IPrivateKeyRepo privateKeyRepo)
        {
            _extractQRCode = extractQRCode;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _qrRCardRepo = qrRCardRepo;
            _awsService = awsService;
            _privateKeyRepo = privateKeyRepo;
            _qrRCardRepo = qrRCardRepo;
        }



        public string DecodeQRCodeFromImage(IFormFile imageStream)
        {
            var result = _extractQRCode.ExtractQrCodeFromImage(imageStream);
            return result;
        }

        public async Task<Result<GetCardRes>> GenerateCard( string cardGuid)
        {

            //var qrCard = QRCard.Create(1, 2, cardGuid, );
            var card = await _qrRCardRepo.GenerateQRCard(cardGuid);
            var qrCoder = _mapper.Map<GetCardRes>(card);
            return qrCoder;
        }

        public async Task<Result<List<GetCardRes>>> GetAllByPaging(int pageNumber, int pageSize)
        {
            var card = await _qrRCardRepo.FindAsync(
                s => true, pageSize, pageNumber,includeProperties: "CardType"
                );
            if(card == null)
            {
                return Result.Failure<List<GetCardRes>>(Error.NotFoundQRCard);
            }

            var result = _mapper.Map<List<GetCardRes>>(card);
            return result;

        

        }

        public async Task<Result<AWSDomainDTO>> DetectShoe(IFormFile image)
        {
            var result = new AWSDomainDTO();
            var key = (await _privateKeyRepo.GetAllAsync()).FirstOrDefault();
            var label = await _awsService.DetectLabelService(image, key);
            label = label.Where(s => s.Label.Equals("Sandal",StringComparison.OrdinalIgnoreCase) || s.Label.Equals("Shoe", StringComparison.OrdinalIgnoreCase)).ToArray();
            if (label.Count == 0)
            {
                return Result.Failure<AWSDomainDTO>(Error.DetectionError);
            }
            result = label.ToArray()[0];
            foreach(var item in label)
            {
                if(result.Confidence < item.Confidence)
                {
                    result = item;
                }
            }
            return result;
        }

        public async Task<Result<GetCardRes>> GetQrCardByCardVerification(string cardVerified)
        {
            var card = (await _qrRCardRepo.FindAsync(
                s => s.CardVerification.Equals(cardVerified), includeProperties: "CardType"
                )).FirstOrDefault();
            if (card == null)
            {
                return Result.Failure<GetCardRes>(Error.NotFoundQRCard);
            }

            var result = _mapper.Map<GetCardRes>(card);
            return result;
        }

        public async Task<Result<bool>> CreateCard(CreateCardCommand command)
        {
            var card = (await _qrRCardRepo.FindAsync(
                s => s.CardVerification.Equals(command.CardVerified)
                )).FirstOrDefault();
            if (card != null)
            {
                return Result.Failure<bool>(Error.DuplicateCard);
            }
            var qrCoder = _qrRCardRepo.GenerateQRCard(command.CardVerified).Result;

            var qrCard = Card.Create(command.CardTypeId, command.CardVerified, qrCoder.CardImage);
            await _qrRCardRepo.AddAsync(qrCard);
            await _unitOfWork.CommitAsync();
            return true;
        }
    }
}
