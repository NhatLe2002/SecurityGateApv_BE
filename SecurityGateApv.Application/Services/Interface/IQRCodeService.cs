using Microsoft.AspNetCore.Http;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
using SecurityGateApv.Domain.Shared;
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
        public bool DetectImage(IFormFile image);
        public Task<Result<AWSDomainDTO>> DetectShoe(IFormFile image);

    }
}
