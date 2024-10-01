using AutoMapper;
using Azure.Core;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
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
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepo _scheduleRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IScheduleTypeRepo _scheduleTypeRepo;
        private readonly IMapper _mapper;

        public ScheduleService(IScheduleRepo scheduleRepo, IUnitOfWork unitOfWork, IMapper mapper, IScheduleTypeRepo scheduleTypeRepo)
        {
            _scheduleRepo = scheduleRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _scheduleTypeRepo = scheduleTypeRepo;
        }

        public async Task<Result<CreateScheduleCommand>> CreateSchedule(CreateScheduleCommand request)
        {
            var scheduleCreate = Schedule.Create(
                request.ScheduleName,
                request.DaysOfProcess,
                request.Duration,
                request.Description,
                DateTime.Now,
                DateTime.Now,
                true,
                request.ScheduleTypeId,
                request.CreateById
               );
            if (scheduleCreate.IsFailure)
            {
                return Result.Failure<CreateScheduleCommand>(Error.ScheduleCreateError);
            }
            await _scheduleRepo.AddAsync(scheduleCreate.Value);
            await _unitOfWork.CommitAsync();

            return request;
        }

        public async Task<Result<bool>> DeleteSchedule(int scheduleId)
        {
            var schedule = await _scheduleRepo.GetByIdAsync(scheduleId);
            if (schedule == null)
            {
                return Result.Failure<bool>(Error.NotFoundSchedule);
            }
            schedule.UpdateStatus(false);
            if (!await _scheduleRepo.UpdateAsync(schedule))
            {
                return Result.Failure<bool>(Error.ScheduleCreateError);
            }
            if (!await _unitOfWork.CommitAsync())
            {
                return Result.Failure<bool>(Error.ScheduleSaveError);
            }
            return true;
        }
        public async Task<Result<ICollection<GetScheduleRes>>> GetAllSchedule(int pageNumber, int pageSize)
        {
            IEnumerable<Schedule> schedule;
            if (pageNumber <= 0 || pageSize <= 0)
            {
                schedule = await _scheduleRepo.GetAllAsync();
            }
            else
            {
                schedule = await _scheduleRepo.FindAsync(
                s => true, pageSize, pageNumber
                );
            }
            if (schedule == null || !schedule.Any())
            {
                return  Result.Failure<ICollection<GetScheduleRes>>(Error.NotFoundSchedule);
            }
            var result = _mapper.Map<IEnumerable<GetScheduleRes>>(schedule);
            return result.ToList();
        }


        public async Task<Result<GetScheduleRes>> GetScheduleById(int scheduleId)
        {
            var schedule = await _scheduleRepo.GetByIdAsync(scheduleId);
            if (schedule == null)
            {
                return Result.Failure<GetScheduleRes>(Error.NotFoundSchedule);
            }
            var result = _mapper.Map<GetScheduleRes>(schedule);
            return result;
        }

        public async Task<Result<GetScheduleRes>> UpdateSchedule(UpdateScheduleCommand request, int scheduleId)
        {
            var schedule = await _scheduleRepo.GetByIdAsync(scheduleId);
            if (schedule == null)
            {
                return Result.Failure<GetScheduleRes>(Error.NotFoundSchedule);
            }
            schedule.Update(request.ScheduleName, request.DaysOfProcess, request.Duration, request.Description, schedule.CreateTime, DateTime.Now, request.Status, request.ScheduleTypeId, request.CreateById);
            if(!await _scheduleRepo.UpdateAsync(schedule))
            {
                return Result.Failure<GetScheduleRes> (Error.ScheduleCreateError);
            }
            if (!await _unitOfWork.CommitAsync())
            {
                return Result.Failure<GetScheduleRes>(Error.ScheduleSaveError);
            }
            var result = _mapper.Map<GetScheduleRes>(schedule);
            return result;
        }
    }
}
