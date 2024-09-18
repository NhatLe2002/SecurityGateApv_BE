using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class NotificationUsers
    {
        [Key]
        public int NotificationUserID { get; set; }
        public bool ReadStatus { get; set; }

        [ForeignKey("Notification")]
        public int NotificationID { get; set; }
        public Notification Notification { get; set; }

        [ForeignKey("Sender")]
        [InverseProperty("SentNotifications")]
        public int SenderID { get; set; }
        public User Sender { get; set; }

        [ForeignKey("Receiver")]
        [InverseProperty("ReceivedNotifications")]
        public int ReceiverID { get; set; }
        public User Receiver { get; set; }
    }
}
