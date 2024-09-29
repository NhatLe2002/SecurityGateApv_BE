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
        public Visitor()
        {
            
        }
        internal Visitor(string visitorName, string companyName, string phoneNumber, int createById, DateTime createdDate, DateTime updatedDate, string credentialsCard, bool status,
            int credentialCardTypeId)
        {
            VisitorName = visitorName;
            //CompanyName = companyName;
            PhoneNumber = phoneNumber;
            //CreatedDate = createdDate;
            //UpdatedDate = updatedDate;
            //CreateById = createById;
            CredentialsCard = credentialsCard;
            //Status = status;
            CredentialCardTypeId = credentialCardTypeId;
        }

        [Key]
        public int VisitorId { get; private set; }
        public string VisitorName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string CredentialsCard { get; private set; }

        [ForeignKey("CredentialCardType")]
        public int CredentialCardTypeId { get; private set; }
        public CredentialCardType CredentialCardType { get; private set; }  
        

        

        public ICollection<VisitDetail> VisitDetails { get; private set; }
        public ICollection<VisitorDepartment> VisitorDepartments { get; private set; }
        public static Result<Visitor> Create(string visitorName, string companyName, string phoneNumber, int createById, DateTime createdDate, DateTime updatedDate, string credentialsCard, bool status,
            int credentialCardTypeId)
        {
            var result = new Visitor(visitorName, companyName, phoneNumber, createById, createdDate, updatedDate, credentialsCard, status, credentialCardTypeId);
            return result;
        }
    }
}
