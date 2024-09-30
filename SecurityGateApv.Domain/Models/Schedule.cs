﻿using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Schedule
    {
        public Schedule()
        {

        }

        public Schedule( string scheduleName, string daysOfSchedule, int duration, string description, DateTime createTime, DateTime updateTime, bool status, int scheduleTypeId,  int createById,  int assignToId)
        {
            ScheduleName = scheduleName;
            DaysOfSchedule = daysOfSchedule;
            Duration = duration;
            Description = description;
            CreateTime = createTime;
            UpdateTime = updateTime;
            Status = status;
            ScheduleTypeId = scheduleTypeId;
            CreateById = createById;
            AssignToId = assignToId;
        }

        private Schedule( string processName , string description, bool status, int visitTypeId, int createBy)
        {
            //ProcessName = processName;
            Description = description;
            Status = status;
            //VisitTypeId = visitTypeId;
            //CreateBy = createBy;
        }

        [Key]
        public int ScheduleId { get; private set; }
        public string ScheduleName { get; private set; }
        public string DaysOfSchedule { get; private set; }
        public int Duration { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateTime { get; private set; } = DateTime.Now;
        public DateTime UpdateTime { get; private set; } = DateTime.Now;
        public bool Status { get; private set; }
        
        [ForeignKey("ScheduleType")]
        public int ScheduleTypeId { get; private set; }
        public ScheduleType ScheduleType { get; private set; }

         [ForeignKey("CreateBy")]
        public int CreateById { get; private set; }
        public User CreateBy { get; private set; }

        [ForeignKey("AssignTo")]
        public int AssignToId { get; private set; }
        public User AssignTo { get; private set; }

        public ICollection<Visit> Visit { get; private set; } 

        public static Result<Schedule> Create(string scheduleName, string daysOfSchedule, int duration, string description, DateTime createTime, DateTime updateTime, bool status, int scheduleTypeId, int createById, int assignToId)
        {
            Schedule schedule = new Schedule( scheduleName, daysOfSchedule,  duration,  description,  createTime,  updateTime,  status,  scheduleTypeId,  createById,  assignToId);
            return schedule;
        }
        
        public Result<Schedule> Update(string scheduleName, string daysOfSchedule, int duration, string description, DateTime createTime, DateTime updateTime, bool status, int scheduleTypeId, int createById, int assignToId)
        {
            ScheduleName = scheduleName;
            DaysOfSchedule = daysOfSchedule;
            Duration = duration;
            Description = description;
            UpdateTime = DateTime.Now;
            Status = status;
            ScheduleTypeId = scheduleTypeId;
            CreateById = createById; 
            AssignToId = assignToId;
            return this;
        }public Result<Schedule> UpdateStatus( bool status)
        {
            UpdateTime = DateTime.Now;
            Status = status;
            return this;
        }
        public Result<Schedule> AddProcessVisitToProcess(DateTime expectedStartDate, DateTime expectedEndDate, TimeSpan expectedStartTime, TimeSpan expectedEndTime, string daysOfProcess,
            int visitQuantity, string status)
        {
            /* var visitProcess = VisitProcess.Create(expectedStartDate, expectedEndDate, expectedStartTime, expectedEndTime, daysOfProcess,
                 visitQuantity, status, this);
             if (visitProcess.IsFailure) {
                 return Result.Failure<Schedule>(visitProcess.Error);
             }
             //this.Visit.Add(visitProcess.Value);
             return this;*/
            return null;
        }
    }
}
