using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class GetVisitRes
    {
        public DateTime DateRegister { get; set; }
        public int VisitQuantity { get; set; }
        public int AcceptLevel { get; set; }
        public ICollection<VisitDetailRes> VisitDetail { get; set; }
    }

    public class VisitDetailRes
    {
        public string VisitDetailName { get; set; }
        public string Description { get; set; }
        public DateTime ExpectedTimeIn { get; set; }
        public DateTime ExpectedTimeOut { get; set; }
        public bool Status { get; set; }
        public VisitorRes Visitor { get; set; }
    }

    public class VisitorRes
    {
        public string VisitorName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CredentialsCard { get; set; }
        public bool Status { get; set; }

        public CredentialCardType CredentialCardType { get; set; }
    }

    public class CredentialCardType
    {
        public string CredentialCardTypeName { get; set; }
    }
}
