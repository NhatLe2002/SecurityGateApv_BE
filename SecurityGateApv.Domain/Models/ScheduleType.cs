using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class ScheduleType
    {
        [Key]
        public int ScheduleTypeId { get; set; }
        public string ScheduleTypeName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public ICollection<Schedule> VisitTypes { get; set; }
    }
}
