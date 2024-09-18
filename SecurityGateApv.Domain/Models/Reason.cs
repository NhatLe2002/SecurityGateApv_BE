using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Reason
    {
        [Key]
        public int ReasonId { get; set; }
        public string ReasonName { get; set; }
        public string Description { get; set; }

        public ICollection<DepartmentReason> DepartmentReason { get; set; }
    }
}
