using SecurityGateApv.Domain.Errors;
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
    public class VisitProcess
    {
        public VisitProcess()
        {
            
        }
        internal VisitProcess(DateTime expectedStartDate, DateTime expectedEndDate, TimeSpan expectedStartTime, TimeSpan expectedEndTime, string daysOfProcess,
            int visitQuantity, string status, Process process)
        {
            ExpectedStartDate = expectedStartDate;
            ExpectedEndDate = expectedEndDate;
            ExpectedStartTime = expectedStartTime;
            ExpectedEndTime = expectedEndTime;
            DaysOfProcess = daysOfProcess;
            VisitQuantity = visitQuantity;
            Status = status;
            Process = process;
        }
        internal VisitProcess(DateTime expectedStartDate, DateTime expectedEndDate, TimeSpan expectedStartTime, TimeSpan expectedEndTime, string daysOfProcess,
    int visitQuantity, string status, int processId)
        {
            ExpectedStartDate = expectedStartDate;
            ExpectedEndDate = expectedEndDate;
            ExpectedStartTime = expectedStartTime;
            ExpectedEndTime = expectedEndTime;
            DaysOfProcess = daysOfProcess;
            VisitQuantity = visitQuantity;
            Status = status;
            ProcessId = processId;
        }

        [Key] 
        public int VisitProcessId { get; private set; }
        public DateTime ExpectedStartDate { get; private set; }
        public DateTime ExpectedEndDate { get; private set; }
        public TimeSpan ExpectedStartTime { get; private set; }
        public TimeSpan ExpectedEndTime { get; private set; }
        public string DaysOfProcess { get; private set; }
        public int VisitQuantity { get; private set; }
        public string Status { get; private set; }


        [ForeignKey("Process")]
        public int ProcessId { get; private set; }
        public Process Process { get; private set; }


        [ForeignKey("Visit")]
        public int? VisitId { get; private set; }
        public Visit? Visit { get; private set; }

        public static Result<VisitProcess> Create(DateTime expectedStartDate, DateTime expectedEndDate, TimeSpan expectedStartTime, TimeSpan expectedEndTime, string daysOfProcess,
            int visitQuantity, string status, int processId)
        {
            var days = daysOfProcess.Split(new char[] { ',' }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            var flag = true;
            foreach(var item in days)
            {
                if(item.Equals("Mon") || item.Equals("Tue") || item.Equals("Wed") || item.Equals("Thu") || item.Equals("Fri") || item.Equals("Sat") || item.Equals("Sun"))
                {
                    continue;
                }
                return Result.Failure<VisitProcess>(Error.ProcessVisitCreateDateError);
            }
            var visitProcess = new VisitProcess(expectedStartDate, expectedEndDate, expectedStartTime, expectedEndTime, daysOfProcess,
                 visitQuantity, status, processId);
            return visitProcess;
        }
        public static Result<VisitProcess> Create(DateTime expectedStartDate, DateTime expectedEndDate, TimeSpan expectedStartTime, TimeSpan expectedEndTime, string daysOfProcess,
            int visitQuantity, string status, Process process)
        {
            var days = daysOfProcess.Split(new char[] { ',' }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in days)
            {
                if (item.Equals("Mon") || item.Equals("Tue") || item.Equals("Wed") || item.Equals("Thu") || item.Equals("Fri") || item.Equals("Sat") || item.Equals("Sun"))
                {
                    continue;
                }
                return Result.Failure<VisitProcess>(Error.ProcessVisitCreateDateError);
            }
            var visitProcess = new VisitProcess(expectedStartDate, expectedEndDate, expectedStartTime, expectedEndTime, daysOfProcess,
                 visitQuantity, status, process);
            return visitProcess;
        }
        public Result<VisitProcess> AddVisitToProcess(Visit visit)
        {
            this.Visit = visit;
            return this;
        }
    }
}
