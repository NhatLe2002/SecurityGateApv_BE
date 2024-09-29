using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitorDepartment
    {
        public int VisitorDepartmentId { get; set; }
        public DateTime CreateDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public string Status { get; private set; }


        [ForeignKey("Visitor")]
        public int VisitorId { get; private set; }
        public Visitor Visitor { get; private set; }

        [ForeignKey("UserDepartment")]
        public int UserDepartmentId { get; private set; }
        public UserDepartment UserDepartment { get; private set; }
    }
}
