﻿using Microsoft.AspNetCore.Http;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Shared;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services.Interface
{
    public interface IQRCodeService
    {
        public string DecodeQRCodeFromImage(IFormFile imageStream);
        public Task<Result<AWSDomainDTO>> DetectShoe(IFormFile image);
        public Task<Result<string>> GenerateQrCar(string data);
        public Task<Result<bool>> CreateQRCard( string guid);
        public Task<Result<List<GetCardRes>>> GetAllByPaging(int pageNumber, int pageSize);
        public Task<Result<GetCardRes>> GetQrCardByCardVerification(string cardVerified);

    }
}
