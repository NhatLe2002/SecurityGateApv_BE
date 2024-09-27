using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class QRCardStatus
    {
        [Key]
        public int QRCardStatusId { get; set; }
        public string StatusName { get; set; }
        public string Description { get; set; }

        public ICollection<QRCard> QRCards { get; set; }
    }
}
