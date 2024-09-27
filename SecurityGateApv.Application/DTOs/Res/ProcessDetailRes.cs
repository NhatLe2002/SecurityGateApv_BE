using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class ProcessDetailRes
    {
        public int VisitProcessId { get; private set; }
        public DateTime ExpectedStartDate { get; private set; }
        public DateTime ExpectedEndDate { get; private set; }
        public TimeSpan ExpectedStartTime { get; private set; }
        public TimeSpan ExpectedEndTime { get; private set; }
        public string DaysOfProcess { get; private set; }
        public int VisitQuantity { get; private set; }
        public string Status { get; private set; }
        public int? VisitId { get; private set; }
    }
}
