using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class DepartmentReason
    {
        [Key]
        public int DepartmentReasonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }


        [ForeignKey("Reason")]
        public int ReasonId { get; set; }
        public Reason Reason { get; set; }
        

        public ICollection<Visit> Visits { get; set; }
    }
}
