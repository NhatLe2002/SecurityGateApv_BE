﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class GetVisitorRes
    {
        public string VisitorName { get; private set; }
        public string CompanyName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string CredentialsCard { get; private set; }
        public string VisitorCredentialImage { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public string Status { get; private set; }
        public CredentialCardTypeRes CredentialCardType { get; private set; }

    }
    public class CredentialCardTypeRes
    {
        public int CredentialCardTypeId { get; private set; }
        public string CredentialCardTypeName { get; private set; }
    }
}
