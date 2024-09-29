using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class ProcessByDepartmentManagerIdRes
    {
        public int ProcessId { get; private set; }
        public string ProcessName { get; private set; }
        public DateTime CreateTime { get; private set; } = DateTime.Now;
        public string Description { get; private set; }
        public bool Status { get; private set; }
        public int VisitTypeId { get; private set; }
        public VisitType VisitType { get; private set; }
        public int CreateBy { get; private set; }
    }
    public class ProcessDetailByDepartmentManagerIdRes
    {
        public int ProcessId { get; private set; }
        public string ProcessName { get; private set; }
        public DateTime CreateTime { get; private set; } = DateTime.Now;
        public string Description { get; private set; }
        public bool Status { get; private set; }
        public int VisitTypeId { get; private set; }
        public VisitType VisitType { get; private set; }
        public int CreateBy { get; private set; }

        public ICollection<ProcessDetailRes> ProcessDetailRes { get; private set; }
    }
}
