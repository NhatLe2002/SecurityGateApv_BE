using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Status { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<Process> Project { get; set; }
        public ICollection<UserDepartment> UserDepartment { get; set; }
        [InverseProperty("Sender")]
        public ICollection<NotificationUsers> SentNotifications { get; set; }

        [InverseProperty("Receiver")]
        public ICollection<NotificationUsers> ReceivedNotifications { get; set; }



        [InverseProperty("CreateBy")]
        public ICollection<Visit> CreatedVisits { get; set; }

        [InverseProperty("UpdateBy")]
        public ICollection<Visit> UpdatedVisits { get; set; }


        public ICollection<VisitorSession> SecurityInSessions { get; set; } 
        public ICollection<VisitorSession> SecurityOutSessions { get; set; }

        public ICollection<VehicleSession> VehicleSession { get; set; }
        public Visitor Visitor { get; set; }
    }
}
