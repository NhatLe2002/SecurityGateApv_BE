using SecurityGateApv.Domain.Enums;
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
    public class ScheduleUser
    {
        public ScheduleUser() { }
        internal ScheduleUser(string title, string description, string? note, DateTime assignTime, DateTime deadlineTime,
            string status, int scheduleId, int assignFromId, int assignToId)
        {
            Title = title;
            Description = description;
            Note = note;
            AssignTime = assignTime;
            DeadlineTime = deadlineTime;
            Status = status;
            ScheduleId = scheduleId;
            AssignToId = assignToId;
            AssignFromId = assignFromId;
        }

        [Key]
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string? Note {  get; private set; }
        public DateTime AssignTime { get; private set; }
        public DateTime DeadlineTime { get; private set; }
        public string Status { get; private set; }
        [ForeignKey("Schedule")]
        public int ScheduleId { get; private set; }
        public Schedule Schedule { get; private set; }
        [ForeignKey("AssignTo")]
        public int AssignToId { get; private set; }
        public User AssignTo { get; private set; }
        [ForeignKey("AssignFrom")]
        public int AssignFromId { get; private set; }
        public User AssignFrom { get; private set; }

        public static Result<ScheduleUser> Create(string title, string description, string? note, DateTime assignTime, DateTime deadlineTime,
            string status, int scheduleId, int assignFromId, int assignToId)
        {
            var scheduleUser = new ScheduleUser(title, description, note, assignTime, deadlineTime,
            status, scheduleId, assignFromId, assignToId);
            return scheduleUser;
        }
        public Result<ScheduleUser> UpdateVisitList()
        {
            this.Status = ScheduleUserStatusEnum.Pending.ToString();
            return this;
        }
    }
}
