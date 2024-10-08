﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.UpdateReq
{
    public class UpdateUserNoDepartmentIdCommand
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string PhoneNumber { get; set; }
        public string? Image { get; set; }
    }
}
