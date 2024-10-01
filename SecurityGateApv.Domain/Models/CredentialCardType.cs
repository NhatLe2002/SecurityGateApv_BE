using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class CredentialCardType
    {
        [Key]
        public int CredentialCardTypeId { get; private set; }
        public string CredentialCardTypeName { get; private set; }
        public string Description { get; private set; }
        public bool Status { get; private set; }
        public ICollection<Visitor> Visitor { get; private set; }
    }
}
