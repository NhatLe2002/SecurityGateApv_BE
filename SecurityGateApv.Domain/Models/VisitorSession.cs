using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitorSession
    {
        [Key]
        public int VisitorSessionId { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }


        [ForeignKey("QRCard")]
        public int QRCardId { get; set; }
        public QRCard QRCard { get; set; }


        [ForeignKey("VisitDetail")]
        public int VisitDetailId { get; set; }
        public VisitDetail VisitDetail { get; set; }


        [ForeignKey("Security")]
        public int SecurityID { get; set; }
        public User Security { get; set; }


        [ForeignKey("Gate")]
        public int GateId { get; set; }
        public Gate Gate { get; set; }

        public ICollection<VisitorSessionsImage> Images { get; set; }
    }
}
