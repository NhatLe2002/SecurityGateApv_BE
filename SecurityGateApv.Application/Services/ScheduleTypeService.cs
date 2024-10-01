using AutoMapper;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services
{
    public class ScheduleTypeService : IScheduleTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IScheduleTypeRepo _scheduleTypeRepo;
        private readonly IMapper _mapper;

        public ScheduleTypeService(IUnitOfWork unitOfWork, IMapper mapper, IScheduleTypeRepo scheduleTypeRepo)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _scheduleTypeRepo = scheduleTypeRepo;
        }

        public async Task<Result<ICollection<GetScheduleTypeRes>>> GetAllScheduleType()
        {
           var scheduleType = _scheduleTypeRepo.GetAllAsync();
            if (scheduleType == null)
            {
                return Result.Failure<ICollection<GetScheduleTypeRes>>(Error.NotFoundSchedule);
            }
            var result = _mapper.Map<ICollection<GetScheduleTypeRes>>(scheduleType);
            return result.ToList();
        }
    }
}
