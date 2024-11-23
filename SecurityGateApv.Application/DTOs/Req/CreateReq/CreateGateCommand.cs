using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.CreateReq
{
    public class CreateGateCommand
    {
        public string GateName { get; set; }
        public string Description { get; set; }
        public string CameraURL { get; set; }
    }
}
