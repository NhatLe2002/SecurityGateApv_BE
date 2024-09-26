using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityGateApv.Domain.Shared;

namespace SecurityGateApv.Domain.Models
{
    public class VisitorSession
    {
        [Key]
        public int VisitorSessionId { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime? CheckoutTime { get; set; }


        [ForeignKey("QRCard")]
        public int QRCardId { get; set; }
        public QRCard QRCard { get; set; }


        [ForeignKey("VisitDetail")]
        public int VisitDetailId { get; set; }
        public VisitDetail VisitDetail { get; set; }


        [ForeignKey("SecurityIn")]
        public int SecurityInId { get; set; }
        public User SecurityIn { get; set; }


        [ForeignKey("SecurityOut")]
        public int? SecurityOutId { get; set; }
        public User? SecurityOut { get; set; }


        [ForeignKey("GateIn")]
        public int GateInId { get; set; }
        public Gate GateIn { get; set; }

        [ForeignKey("GateOut")]
        public int? GateOutId { get; set; }
        public Gate? GateOut { get; set; }

        public string Status { get; set; }
        public ICollection<VisitorSessionsImage> Images { get; set; }

        /*public Result<VisitorSession> UpdateVisitorSesson()
        {
            var visitorSesson = new VisitorSession
            
            return this;
        }*/
    }
}
