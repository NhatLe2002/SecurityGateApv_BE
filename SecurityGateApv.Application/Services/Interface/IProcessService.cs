using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services.Interface
{
    public interface IProcessService
    {
        public Task<Result<ICollection<ProcessByDepartmentManagerIdRes>>> GetAllProcessByDepartmentManagerId(int managerId);
        public Task<Result<ICollection<ProcessDetailRes>>> GetProcessDetail(int processId);
        public Task<Result<ProcessCreateCommand>> CreateProcess(ProcessCreateCommand request);
        public Task<Result<ICollection<VisitProcessCommand>>> AddProcessVisit(int processId, ICollection<VisitProcessCommand> request);
    }
}
