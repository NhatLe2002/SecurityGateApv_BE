using SecurityGateApv.Domain.Common;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Visit
    {
        public Visit()
        {
            
        }

        public Visit(string visitName, int visitQuantity, DateTime expectedStartTime, DateTime expectedEndTime, DateTime createTime
            , DateTime updateTime, string? description, string visitStatus, int createById, int scheduleId)
        {
            VisitName = visitName;
            VisitQuantity = visitQuantity;
            ExpectedStartTime = expectedStartTime;
            ExpectedEndTime = expectedEndTime;
            CreateTime = createTime;
            UpdateTime = updateTime;
            Description = description;
            VisitStatus = visitStatus;
            CreateById = createById;
            ScheduleId = scheduleId;
        }

        [Key]
        public int VisitId { get;  set; }
        public string VisitName { get; private set; }
        public int VisitQuantity { get; private set; }
        public DateTime ExpectedStartTime { get; private set; }
        public DateTime ExpectedEndTime { get; private set; }
        public DateTime CreateTime { get; private set; }
        public DateTime UpdateTime { get; private set; }
        public string? Description { get; private set; }
        public string VisitStatus { get; private set; }

        [ForeignKey("CreateBy")]
        public int CreateById { get; private set; }
        public User CreateBy { get; private set; }

        [ForeignKey("UpdateBy")]
        public int? UpdateById { get; private set; }
        public User? UpdateBy { get; private set; }
        
        [ForeignKey("Schedule")]
        public int ScheduleId { get; private set; }
        public Schedule Schedule { get; private set; }

        public ICollection<VisitDetail> VisitDetail { get; private set; } = new List<VisitDetail>();

        public static Result<Visit> Create(string visitName, int visitQuantity, DateTime expectedStartTime, DateTime expectedEndTime, DateTime createTime
            , DateTime updateTime, string? description, string visitStatus, int createById, int scheduleId)
        {
            var result = new Visit(visitName, visitQuantity, expectedStartTime, expectedEndTime, createTime
            , updateTime, description, visitStatus, createById, scheduleId);
            return result;
        }

        public async Task<Result<Visit>> AddVisitDetailOfOldVisitor(IEnumerable<VisitDetail> visitSchedule, Schedule schedule,TimeSpan expectedStartHour, TimeSpan expectedEndHour,bool status
            , int visitorId)
        {
            if(VisitDetail.Any(s => s.VisitorId == visitorId))
            {
                return Result.Failure<Visit>(Error.DuplicateVisitorDetail);
            }
            var visitDetailAdd = new VisitDetail(expectedStartHour, expectedEndHour, status
            , this, visitorId);
            var visitBusyOfVisitor = new List<ValidateVisitDateDTO>();
            foreach (VisitDetail visit in visitSchedule) {
                visitBusyOfVisitor.AddRange(await CommonService.CaculateBusyDates(visit));
            }

            visitDetailAdd.Visit.Schedule = schedule;
            var visitorFutureBusy = await CommonService.CaculateBusyDates(visitDetailAdd);
            if(visitorFutureBusy.Count() == 0)
            {
                return Result.Failure<Visit>(Error.NoValidDateForVisit);
            }
            var error = new List<int>();
            foreach (var dateOfBusy in visitorFutureBusy)
            {
 
                var check = visitBusyOfVisitor.Where(s => dateOfBusy.VisitDate.Year == s.VisitDate.Year && dateOfBusy.VisitDate.Month == s.VisitDate.Month && dateOfBusy.VisitDate.Day == s.VisitDate.Day);

                if (check != null)
                {
/*                    if(check.Any(s => s.TimeIn >= dateOfBusy.TimeIn) && check.Any(s => s.TimeIn < dateOfBusy.TimeOut))
                    {
                        error.Add(check.)
                    }
                    if (check.Any(s => s.TimeOut > dateOfBusy.TimeIn) && check.Any(s => s.TimeOut <= dateOfBusy.TimeOut))
                    {

                    }*/
                    foreach (var day in check)
                    {
                        if (day.TimeIn >= dateOfBusy.TimeIn && day.TimeIn < dateOfBusy.TimeOut)
                        {
                            error.Add((int)day.VisitId);
                            continue;
                        }
                        if (day.TimeOut > dateOfBusy.TimeIn && day.TimeOut <= dateOfBusy.TimeOut)
                        {
                            error.Add((int)day.VisitId);
                            continue;
                        }
                    }
                }
            }
            if (error.Distinct().Count() > 0)
            {
                return Result.Failure<Visit>(new Error("CreateVisit", "Visitor busy at visit Id: " + string.Join(", ", error)));
            }
            VisitDetail.Add(visitDetailAdd);
            return this;
        }
        public Result<Visit> Update(int updateById)
        {
            this.UpdateById = updateById;
            this.UpdateTime = DateTime.Now;
            return this;
        }
    }
}
