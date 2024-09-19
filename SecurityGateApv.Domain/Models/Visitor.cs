using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Visitor
    {
        protected Visitor()
        {
            
        }
        internal Visitor(string visitorName, string companyName, string phoneNumber, DateTime createdDate, DateTime updatedDate, string credentialsCard, bool status,
            int credentialCardTypeId)
        {
            VisitorName = visitorName;
            CompanyName = companyName;
            PhoneNumber = phoneNumber;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            CredentialsCard = credentialsCard;
            Status = status;
            CredentialCardTypeId = credentialCardTypeId;
        }

        [Key]
        public int VisitorId { get; private set; }
        public string VisitorName { get; private set; }
        public string CompanyName { get; private set; }
        public string PhoneNumber { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public string CredentialsCard { get; private set; }
        public bool Status { get; private set; }

        [ForeignKey("CredentialCardType")]
        public int CredentialCardTypeId { get; private set; }
        public CredentialCardType CredentialCardType { get; private set; }

        public ICollection<VisitDetail> VisitDetail { get; private set; }
        public static Result<Visitor> Create(string visitorName, string companyName, string phoneNumber, DateTime createdDate, DateTime updatedDate, string credentialsCard, bool status,
            int credentialCardTypeId)
        {
            var result = new Visitor(visitorName, companyName, phoneNumber, createdDate, updatedDate, credentialsCard, status, credentialCardTypeId);
            return result;
        }
    }
}
