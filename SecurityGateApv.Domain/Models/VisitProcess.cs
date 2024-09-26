using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitProcess
    {
        [Key] 
        public int VisitProcessId { get; set; }
        public DateTime ExpectedStartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public TimeSpan ExpectedStartTime { get; set; }
        public TimeSpan ExpectedEndTime { get; set; }
        public string DaysOfProcess { get; set; }
        public int VisitQuantity { get; set; }
        public string Status { get; set; }


        [ForeignKey("Process")]
        public int ProcessId { get; set; }
        public Process Process { get; set; }


        [ForeignKey("Visit")]
        public int? VisitId { get; set; }
        public Visit? Visit { get; set; }
    }
}
