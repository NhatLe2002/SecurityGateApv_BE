using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class CardType
    {
        [Key]
        public int QRCardTypeId { get; set; }
        public string CardTypeName { get; set; }
        public string TypeDescription { get; set; }

        public ICollection<Card> QRCards { get; set; }
    }
}
