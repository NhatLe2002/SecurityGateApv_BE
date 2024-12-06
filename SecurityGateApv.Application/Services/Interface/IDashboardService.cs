using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services.Interface
{
    public interface IDashboardService
    {
        public Task<Result<DashBoardVisitRes>> GetVisit();
        public Task<Result<DashboardUserRes>> GetUser();
        public Task<Result<DashboardVisitorRes>> GetVisitor();
        public Task<Result<DashboardSchedule>> GetSchedule();
        public Task<Result<DashboardMission>> GetMission(int? staffId);
    }
}
