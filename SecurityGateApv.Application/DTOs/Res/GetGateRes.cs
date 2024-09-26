using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class GetGateRes
    {
        public int GateId { get; set; }
        public string GateName { get; set; }
        public string GateCoordinate { get; set; }
    }
}
