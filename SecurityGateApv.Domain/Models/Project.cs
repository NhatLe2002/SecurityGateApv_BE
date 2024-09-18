using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Status { get; set; }
        
        [ForeignKey("User")]
        public int CreateBy { get; set; }

        public User User { get; set; }

        public ICollection<VisitProject> VisitProject { get; set; }
    }
}
