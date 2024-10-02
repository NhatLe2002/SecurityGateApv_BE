using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
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

        public Result<Visit> AddVisitDetailOfOldVisitor(TimeSpan expectedStartHour, TimeSpan expectedEndHour, bool status, int visitorId)
        {
            var visitDetail = new VisitDetail(expectedStartHour, expectedEndHour, status
            , this, visitorId);
            VisitDetail.Add(visitDetail);
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
