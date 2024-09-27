using Microsoft.AspNetCore.Http;
using SecurityGateApv.Application.DTOs.Res;
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
        public Task<Result<string>> GenerateQrCar(string data);
        public Task<Result<bool>> CreateQRCard( string guid);
        public Task<Result<List<GetCardRes>>> GetAllByPaging(int pageNumber, int pageSize);

    }
}
