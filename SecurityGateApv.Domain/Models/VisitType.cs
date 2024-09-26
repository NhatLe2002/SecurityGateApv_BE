using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitType
    {
        [Key]
        public int VisitTypeId { get; set; }
        public string VisitTypeName { get; set; }
        public string Description { get; set; }

        public ICollection<Process> VisitTypes { get; set; }
    }
}
