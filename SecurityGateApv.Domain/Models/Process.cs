using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Process
    {
        public Process()
        {

        }
        private Process( string processName , string description, bool status, int visitTypeId, int createBy)
        {
            ProcessName = processName;
            Description = description;
            Status = status;
            VisitTypeId = visitTypeId;
            CreateBy = createBy;
        }

        [Key]
        public int ProcessId { get; private set; }
        public string ProcessName { get; private set; }
        public DateTime CreateTime { get; private set; } = DateTime.Now;
        public string Description { get; private set; }
        public bool Status { get; private set; }
        
        [ForeignKey("VisitType")]
        public int VisitTypeId { get; private set; }

        public VisitType VisitType { get; private set; }


         [ForeignKey("User")]
        public int CreateBy { get; private set; }

        public User User { get; private set; }

        public ICollection<VisitProcess> VisitProject { get; private set; } = new List<VisitProcess>();

        public static Result<Process> Create(string processName, string description, bool status, int visitTypeId, int createBy)
        {
            Process process = new Process(processName, description, status, visitTypeId, createBy);

            return process;
        }
        public Result<Process> AddProcessVisitToProcess(DateTime expectedStartDate, DateTime expectedEndDate, TimeSpan expectedStartTime, TimeSpan expectedEndTime, string daysOfProcess,
            int visitQuantity, string status)
        {
            var visitProcess = VisitProcess.Create(expectedStartDate, expectedEndDate, expectedStartTime, expectedEndTime, daysOfProcess,
                visitQuantity, status, this);
            if (visitProcess.IsFailure) {
                return Result.Failure<Process>(visitProcess.Error);
            }
            this.VisitProject.Add(visitProcess.Value);
            return this;
        }
    }
}
