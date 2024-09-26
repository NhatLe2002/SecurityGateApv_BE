using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitDetail
    {
        public VisitDetail()
        {

        }
        internal VisitDetail(string visitDetailName, string description, DateTime expectedTimeIn, DateTime expectedTimeOut, bool status, Visit visit, Visitor visitor)
        {
            //VisitDetailName = visitDetailName;
            Description = description;
            ExpectedStartDate = expectedTimeIn;
            ExpectedEndDate = expectedTimeOut;
            Status = status;
            Visit = visit;
            Visitor = visitor;
        }
        internal VisitDetail(string visitDetailName, string description, DateTime expectedTimeIn, DateTime expectedTimeOut, bool status, Visit visit, int visitorId)
        {
            //VisitDetailName = visitDetailName;
            Description = description;
            ExpectedStartDate = expectedTimeIn;
            ExpectedEndDate = expectedTimeOut;
            Status = status;
            Visit = visit;
            VisitorId = visitorId;
        }

        [Key]
        public int VisitDetailId { get; private set; }
        public DateTime ExpectedStartDate { get; private set; }
        public DateTime ExpectedEndDate { get; private set; }
        public TimeSpan ExpectedStartTime { get; private set; }
        public TimeSpan ExpectedEndTime { get; private set; }
        public string? Description { get; private set; }
        public bool Status { get; private set; }

        [ForeignKey("Visit")]
        public int VisitId { get; private set; }
        public Visit Visit { get; private set; }


        [ForeignKey("Visitor")]
        public int VisitorId { get; private set; }
        public Visitor Visitor { get; private set; }

        public ICollection<VisitorSession> VisitorSession { get; private set; }
        public ICollection<VehicleSession> VehicleSession { get; private set; }
    }
}
