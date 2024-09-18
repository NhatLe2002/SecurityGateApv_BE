using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitDetail
    {
        [Key]
        public int VisitDetailId { get; set; }
        public string VisitDetailName { get; set; }
        public string Description { get; set; }
        public DateTime ExpectedTimeIn { get; set; }
        public DateTime ExpectedTimeOut { get; set; }
        public bool Status { get; set; }

        [ForeignKey("Visit")]
        public int VisitId { get; set; }
        public Visit Visit { get; set; }


        [ForeignKey("Visitor")]
        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }

        public ICollection<VehicleSession> VehicleSession { get; set; }
        public ICollection<VisitorSession> VisitorSession { get; set; }
    }
}
