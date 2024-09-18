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
        public int StatusName { get; set; }
        public int StatusNumber { get; set; }

        public ICollection<QRCard> QRCards { get; set; }
    }
}
