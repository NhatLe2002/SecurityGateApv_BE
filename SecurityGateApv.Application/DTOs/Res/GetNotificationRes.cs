using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class GetNotificationRes
    {
        public int NotificationUserID { get; set; }
        public bool ReadStatus { get; set; }
        public int NotificationID { get; set; }
        public GetNotification Notification { get; set; }
        public int SenderID { get; set; }       
        public int ReceiverID { get; set; }
    }
    public class GetNotification
    {
        public int NotificationID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool Status { get; set; }
    }
}
