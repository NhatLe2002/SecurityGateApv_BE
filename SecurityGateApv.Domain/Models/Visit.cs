using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }
        public DateTime DateRegister { get; set; }
        public int VisitQuantity { get; set; }
        public int AcceptLevel { get; set; }


        [ForeignKey("DepartmentReason")]
        public int DepartmentReasonId { get; set; }
        public DepartmentReason DepartmentReason { get; set; }



        [ForeignKey("CreateBy")]
        public int CreateById { get; set; }
        public User CreateBy { get; set; }

        [ForeignKey("UpdateBy")]
        public int UpdateById { get; set; }
        public User UpdateBy { get; set; }

        public ICollection<VisitProject> VisitProject { get; set; }
        public ICollection<VisitDetail> VisitDetail { get; set; }

    }
}
