using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req
{
    public  class VisitorSessionCheckinCommand
    {
        public DateTime CheckinTime { get; set; }


        public int VisitDetailId { get; set; }

        public int SecurityId { get; set; }


        public int GateId { get; set; }

        public ICollection<VehicleSessionImage> Images { get; set; }
    }
}
