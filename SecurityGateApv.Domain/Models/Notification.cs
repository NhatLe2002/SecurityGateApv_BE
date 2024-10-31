using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Notification
    {
        public Notification()
        {
            
        }
        public Notification(string title, string content, DateTime sentDate, DateTime? readDate, bool status)
        {
            Title = title;
            Content = content;
            SentDate = sentDate;
            ReadDate = readDate;
            Status = status;
        }

        [Key]
        public int NotificationID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool Status { get; set; }
        public ICollection<NotificationUsers> NotificationUsers { get; set; } = new List<NotificationUsers>();
        public static Result<Notification> Create(string title, string content, DateTime sentDate, DateTime? readDate)
        {
            var noti = new Notification(title, content, sentDate, readDate, true);
            return noti;
        }
        public Result<Notification> AddUserNoti(int senderID, int receiverID)
        {
            var userNoti = new NotificationUsers(false, this, senderID, receiverID);
            this.NotificationUsers.Add(userNoti);
            return this;
        }
    }
}
