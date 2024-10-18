﻿using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class GetVisitorCreateRes
    {
        public int VisitorId { get;  set; }
        public string VisitorName { get;  set; }
        public string CompanyName { get;  set; }
        public string PhoneNumber { get;  set; }
        public string CredentialsCard { get;  set; }
        public string VisitorCredentialImage { get;  set; }
        public DateTime CreateDate { get;  set; }
        public string Status { get; set; }
        public int CredentialCardTypeId { get; set; }
    }
}
