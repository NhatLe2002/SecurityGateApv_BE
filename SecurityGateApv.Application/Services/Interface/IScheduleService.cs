using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services.Interface
{
    public interface IScheduleService
    {
        public Task<Result<ICollection<GetScheduleRes>>> GetAllSchedule(int pageNumber, int pageSize);
        public Task<Result<GetScheduleRes>> GetScheduleById(int scheduleId);
        public Task<Result<CreateScheduleCommand>> CreateSchedule(CreateScheduleCommand request);
        public Task<Result<GetScheduleRes>> UpdateSchedule(UpdateScheduleCommand request, int scheduleId);
        public Task<Result<bool>> DeleteSchedule( int scheduleId);
        public Task<Result<CreateScheduleUserCommand>> CreateScheduleUser(CreateScheduleUserCommand command);
    }
}
