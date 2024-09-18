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
        [Key]
        public int VisitorId { get; set; }
        public string VisitorName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CredentialsCard { get; set; }
        public bool Status { get; set; }

        [ForeignKey("CredentialCardType")]
        public int CredentialCardTypeId { get; set; }
        public CredentialCardType CredentialCardType { get; set; }

        public ICollection<VisitDetail> VisitDetail { get; set; }
    }
}
