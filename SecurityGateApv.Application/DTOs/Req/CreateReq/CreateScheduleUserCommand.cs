using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.CreateReq
{
    public class CreateScheduleUserCommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Note { get; set; }
        public DateTime DeadlineTime { get; set; }
        public int ScheduleId { get; set; }
        public int AssignToId { get; set; }
    }
}
