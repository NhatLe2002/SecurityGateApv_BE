using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Gate
    {
        [Key]
        public int GateId { get; set; }
        public string GateName { get; set; }
        public string GateCoordinate { get; set;}

        public ICollection<VisitorSession> VisitorSessionsIn { get; set; } 
        public ICollection<VisitorSession> VisitorSessionsOut { get; set; }
        public ICollection<VehicleSession> VehicleSession{ get; set; }


    }
}
