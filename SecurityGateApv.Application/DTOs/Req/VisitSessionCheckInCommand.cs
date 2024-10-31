using Microsoft.AspNetCore.Http;
using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req
{
    public class VisitSessionCheckInCommand
    {
        //public int QRCardId { get; set; }
        public string? CredentialCard { get; set; }
        public int SecurityInId { get; set; }
        public int GateInId { get; set; }
        public string QRCardVerification {  get; set; }
        public List<VisitorSessionsImageCheckinCommand> Images { get; set; }
    }
    public class VisitorSessionsImageCheckinCommand
    {
        public string ImageType { get; set; }
        public string ImageURL { get; set; }
        //[JsonIgnore]
        public IFormFile Image { get; set; }
    }

}
