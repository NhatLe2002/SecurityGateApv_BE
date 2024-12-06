using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class DashBoardVisitRes
    {
        public int Total {  get; set; }
        public int Daily { get; set; }
        public int Week {  get; set; }
        public int Month { get; set; }
        public int Cancel { get; set; }
        public int Violation { get; set; }
    }
}
