using AutoMapper;
using Microsoft.AspNetCore.Http;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Interfaces.ExtractImage;
using SecurityGateApv.Domain.Interfaces.Repositories;
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
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public QRCodeService(IExtractQRCode extractQRCode, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _extractQRCode = extractQRCode;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public string DecodeQRCodeFromImage(IFormFile imageStream)
        {
            var result = _extractQRCode.ExtractQrCodeFromImage(imageStream);
            return result;
        }
    }
}
