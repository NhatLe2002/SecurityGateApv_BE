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
        public int CredentialCardTypeId { get; set; }
        public string CredentialCardTypeName { get; set; }

        public ICollection<Visitor> Visitor { get; set; }
    }
}
