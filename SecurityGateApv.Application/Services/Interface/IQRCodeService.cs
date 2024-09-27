using Microsoft.AspNetCore.Http;
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
        public string GenerateQrCar(string data);

    }
}
