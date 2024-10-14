using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityGateApv.Domain.Shared;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Enums;

namespace SecurityGateApv.Domain.Models
{
    public class VisitorSession
    {
        public VisitorSession()
        {
            
        }
        internal VisitorSession(DateTime checkin, DateTime? checkout, int qrCardId, int visitDetailId, int securityInId, int? securityOutId, int gateIn, int? gateOut, string status)
        {
            CheckinTime = checkin;
            CheckoutTime = checkout;
            QRCardId = qrCardId;
            VisitDetailId = visitDetailId;
            SecurityInId = securityInId;
            SecurityOutId = securityOutId;
            GateInId = gateIn;
            GateOutId = gateOut;
            Status = status;
        }
        [Key]
        public int VisitorSessionId { get;  set; }
        public DateTime CheckinTime { get; private set; }
        public DateTime? CheckoutTime { get; private set; }


        [ForeignKey("QRCard")]
        public int QRCardId { get; private set; }
        public QRCard QRCard { get; private set; }


        [ForeignKey("VisitDetail")]
        public int VisitDetailId { get; private set; }
        public VisitDetail VisitDetail { get; private set; }


        [ForeignKey("SecurityIn")]
        public int SecurityInId { get; private set; }
        public User SecurityIn { get; private set; }


        [ForeignKey("SecurityOut")]
        public int? SecurityOutId { get; private set; }
        public User? SecurityOut { get; private set; }


        [ForeignKey("GateIn")]
        public int GateInId { get; private set; }
        public Gate GateIn { get; private set; }

        [ForeignKey("GateOut")]
        public int? GateOutId { get; private set; }
        public Gate? GateOut { get; private set; }

        public string Status { get; private set; }
        public ICollection<VisitorSessionsImage> Images { get; private set; } = new List<VisitorSessionsImage>();


        public static Result<VisitorSession> Checkin(int qRCard, int visitdetailId, int securityInId, int gateInId)
        {
            var visitorSession = new VisitorSession(DateTime.Now, null, qRCard, visitdetailId, securityInId, null, gateInId, null, VisitorSessionStatus.CheckIn.ToString());

            return Result.Success(visitorSession);
        }
        public Result<VisitorSession> AddVisitorImage(string imageType, string imageURL)
        {
            var imageVisitorSession = new VisitorSessionsImage(imageType, imageURL, this);
            Images.Add(imageVisitorSession);
            return this;
        }
        /*public Result<VisitorSession> UpdateVisitorSesson()
        {
            var visitorSesson = new VisitorSession
            
            return this;
        }*/
    }
}
