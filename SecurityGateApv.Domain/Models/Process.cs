using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Process
    {
        [Key]
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public DateTime CreateTime { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        
        [ForeignKey("VisitType")]
        public int VisitTypeId { get; set; }

        public VisitType VisitType { get; set; }


         [ForeignKey("User")]
        public int CreateBy { get; set; }

        public User User { get; set; }

        public ICollection<VisitProcess> VisitProject { get; set; }
    }
}
