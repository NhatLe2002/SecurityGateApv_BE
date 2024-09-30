using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.UpdateReq
{
    public class UpdateScheduleCommand
    {
        public string ScheduleName { get; set; }
        public string DaysOfProcess { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public bool Status { get;  set; }
        public int ScheduleTypeId { get; set; }
        public int CreateById { get; set; }
        public int AssignToId { get; set; }
    }
}
