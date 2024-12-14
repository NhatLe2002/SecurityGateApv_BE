using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.UpdateReq
{
    public class UpdateVisitorCommand
    {
        public string VisitorName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; private set; }
        public string CredentialsCard { get; set; }
        public int CredentialCardTypeId { get; set; }
        [JsonIgnore]
        public string VisitorCredentialFrontImageFromRequest { get; set; }
        [JsonIgnore]
        public string VisitorCredentialBackImageFromRequest { get; set; }
        [JsonIgnore]
        public string VisitorCredentialBlurImageFromRequest { get; set; }
    }
}

