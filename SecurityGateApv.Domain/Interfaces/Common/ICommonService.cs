using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Interfaces.Common
{
    public interface ICommonService
    {
        public Task<string> ImageToBase64(IFormFile image);
    }
}
