using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Interfaces.Repositories
{
    public interface IQRCardRepo : IRepoBase<Card>
    {
        public Task<string> GenerateQRCard(string cardIdGuid);
    }
}
