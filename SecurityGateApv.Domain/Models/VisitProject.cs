using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitProject
    {
        [Key] 
        public int VisitProjectId { get; set; }
        public string VisitName { get; set; }
        public int QuantityOfVisit { get; set; }
        public DateTime ExpectedTimeIn { get; set; }
        public DateTime ExpectedTimeOut { get; set; }
        public bool Status { get; set; }


        [ForeignKey("Project")]
        public int ProjectId { get; set; }

        public Project Project { get; set; }


        [ForeignKey("Visit")]
        public int VisitId { get; set; }

        public Visit Visit { get; set; }
    }
}
