using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Interfaces.Jwt
{
    public interface IJwt
    {
        public string GenerateJwtToken(string role);
    }
}
