using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class GetUserRes
    {
        public int UserId { get; set; }
        public string FullName { get;  set; }
        public string Email { get;  set; }
        public string PhoneNumber { get;  set; }

        public string? Image { get;  set; }
        public string Status { get;  set; }

        public RoleRes Role { get;  set; }
    }

    public class RoleRes
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
