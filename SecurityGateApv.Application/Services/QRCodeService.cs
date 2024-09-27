using AutoMapper;
using Microsoft.AspNetCore.Http;
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
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services
{
    public class QRCodeService : IQRCodeService
    {
        private readonly IExtractQRCode _extractQRCode;
        private readonly IQRCardRepo _qrRCardRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAWSService _awsService;
        public QRCodeService(IExtractQRCode extractQRCode, IMapper mapper, IUnitOfWork unitOfWork, IAWSService awsService)
        {
            _extractQRCode = extractQRCode;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _qrRCardRepo = qrRCardRepo;
            _awsService = awsService;
        }

        public string DecodeQRCodeFromImage(IFormFile imageStream)
        {
            var result = _extractQRCode.ExtractQrCodeFromImage(imageStream);
            return result;
        }

        public string GenerateQrCar(string data)
        {
            var qrCard = QRCard.Create(1, 2);
            var qrCoder = _qrRCardRepo.GenerateQRCard(data);
            return qrCoder.Result;
        }

        public bool DetectImage(IFormFile image)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<AWSDomainDTO>> DetectShoe(IFormFile image)
        {
            var result = new AWSDomainDTO();
            var label = await _awsService.DetectLabelService(image);
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
    }
}
