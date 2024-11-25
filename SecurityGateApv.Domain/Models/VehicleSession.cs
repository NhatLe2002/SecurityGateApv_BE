using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VehicleSession
    {
        public VehicleSession()
        {
            
        }
        internal VehicleSession(string licensePlate, DateTime checkin, DateTime? checkout, int visitDetailId, int securityInId, int? securityOutId, int gateIn, int? gateOut, string status)
        {
            LicensePlate = licensePlate;
            CheckinTime = checkin;
            CheckoutTime = checkout;
            VisitDetailId = visitDetailId;
            SecurityInId = securityInId;
            SecurityOutId = securityOutId;
            GateInId = gateIn;
            GateOutId = gateOut;
            Status = status;
        }
        [Key]
        public int VehicleSessionId { get; set; }
        public string LicensePlate { get; private set; }
        public DateTime CheckinTime { get; private set; }
        public DateTime? CheckoutTime { get; private set; }
        public string Status { get; private set; }

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

        public ICollection<VehicleSessionImage> Images { get; private set; } = new List<VehicleSessionImage>();
        public static Result<VehicleSession> Checkin(string licensePlate, int visitdetailId, int securityInId, int gateInId)
        {
            var visitorSession = new VehicleSession(licensePlate,DateTime.Now, null, visitdetailId, securityInId, null, gateInId, null, SessionStatus.CheckIn.ToString());

            return Result.Success(visitorSession);
        }
        public  Result<VehicleSession> CheckOut(int securityOutId, int gateOutId, List<(string ImageType, string ImageURL)> images)
        {
            if (Status != SessionStatus.CheckIn.ToString())
            {
                return Result.Failure<VehicleSession>(Error.ValidVehicleSessionCheckOut);
            }
            SecurityOutId = securityOutId;
            GateOutId = gateOutId;
            CheckoutTime = DateTime.Now;
            Status = SessionStatus.CheckOut.ToString();

            foreach (var image in images)
            {
                var imageVisitorSession = new VehicleSessionImage(image.ImageType, image.ImageURL, this);
                Images.Add(imageVisitorSession);
            }
            return Result.Success(this);
        }
        public Result<VehicleSession> AddVehicleSessionImage(string imageType, string imageURL)
        {
            var imageVisitorSession = new VehicleSessionImage(imageType, imageURL, this);
            Images.Add(imageVisitorSession);
            return this;
        }
    }
}
