﻿using System;
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

        public VisitDetail(TimeSpan expectedStartHour, TimeSpan expectedEndHour, bool status
            , Visit visit, int visitorId)
        {
            ExpectedStartHour = expectedStartHour;
            ExpectedEndHour = expectedEndHour;
            Status = status;
            Visit = visit;
            VisitorId = visitorId;
        }

        [Key]
        public int VisitDetailId { get; private set; }
        public TimeSpan ExpectedStartHour { get; private set; }
        public TimeSpan ExpectedEndHour { get; private set; }
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
