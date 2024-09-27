using AutoMapper;
using Microsoft.AspNetCore.Http;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Interfaces.ExtractImage;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
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
        public QRCodeService(IExtractQRCode extractQRCode, IMapper mapper, IUnitOfWork unitOfWork, IQRCardRepo qrRCardRepo)
        {
            _extractQRCode = extractQRCode;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _qrRCardRepo = qrRCardRepo;
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
    }
}
