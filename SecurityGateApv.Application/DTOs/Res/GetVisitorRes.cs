﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class GetVisitorRes
    {
        public int VisitorId { get;  set; }
        public string VisitorName { get;  set; }
        public string CompanyName { get;  set; }
        public string PhoneNumber { get;  set; }
        public string CredentialsCard { get;  set; }
        public string CreateByName { get;  set; }
        
    }
}
