using AutoMapper;
using SecurityGateApv.Application.DTOs.Req;
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
    public class ProcessSerivce : IProcessService
    {
        private readonly IProcessRepo _processRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVistProcessRepo _vistProcessRepo;
        private readonly IVisitTypeRepo _visitTypeRepo;
        private readonly IMapper _mapper;

        public ProcessSerivce(IProcessRepo processRepo, IUnitOfWork unitOfWork, IVistProcessRepo vistProcessRepo, IMapper mapper, IVisitTypeRepo visitTypeRepo)
        {
            _processRepo = processRepo;
            _unitOfWork = unitOfWork;
            _vistProcessRepo = vistProcessRepo;
            _mapper = mapper;
            _visitTypeRepo = visitTypeRepo;
        }

        public async Task<Result<ICollection<VisitProcessCommand>>> AddProcessVisit(int processId, ICollection<VisitProcessCommand> request)
        {
            var process = await _processRepo.IsAny(s => s.ProcessId == processId);
            if (!process)
            {
                return Result.Failure<ICollection<VisitProcessCommand>>(Error.ProcessNotFoundError);
            }
            List<VisitProcess> listVisitProcess = new();
            foreach(var item in request)
            {
               var createVisitProcess = VisitProcess.Create(item.ExpectedStartDate,
                      item.ExpectedEndDate,
                      item.ExpectedStartTime,
                      item.ExpectedEndTime,
                      item.DaysOfProcess,
                      item.VisitQuantity,
                      VisitProcessEnum.Pending.ToString(),
                      processId
                    );
                if (createVisitProcess.IsFailure)
                {
                    return Result.Failure<ICollection<VisitProcessCommand>>(createVisitProcess.Error); 
                }
                listVisitProcess.Add(createVisitProcess.Value);
            }
            await _vistProcessRepo.AddRangeAsync(listVisitProcess);
            await _unitOfWork.CommitAsync();
            return request.ToList();

        }

        public async Task<Result<ProcessCreateCommand>> CreateProcess(ProcessCreateCommand request)
        {
            var processCreate = Process.Create(request.ProcessName,
                request.Description,
                true,
                request.VisitTypeId,
                request.CreateBy
                );
            if (processCreate.IsFailure)
            {
                return Result.Failure<ProcessCreateCommand>(Error.ProcessCreateError);
            }
            var process = processCreate.Value;

            //var visitType = await _visitTypeRepo.GetByIdAsync(request.VisitTypeId);
            
            
            //add process visit
            foreach(var item in request.VisitProject)
            {
                var result = process.AddProcessVisitToProcess(
                    item.ExpectedStartDate,
                    item.ExpectedEndDate,
                    item.ExpectedStartTime,
                    item.ExpectedEndTime,
                    item.DaysOfProcess,
                    item.VisitQuantity,
                    VisitProcessEnum.Pending.ToString()
                    );
                if (result.IsFailure)
                {
                    return Result.Failure<ProcessCreateCommand>(result.Error);
                }
               
            }
            await _processRepo.AddAsync(process);
            await _unitOfWork.CommitAsync();
            return request;

        }

        public async Task<Result<ICollection<ProcessByDepartmentManagerIdRes>>> GetAllProcessByDepartmentManagerId(int managerId)
        {
            var process = (await _processRepo.FindAsync(s => s.User.UserId == managerId, int.MaxValue, 1)).ToList();
            if(process.Count == 0)
            {
                return Result.Failure<ICollection<ProcessByDepartmentManagerIdRes>>(Error.NotFound);
            }

            var res = _mapper.Map<ICollection<ProcessByDepartmentManagerIdRes>>(process);
            return res.ToList();
        }

        public async Task<Result<ICollection<ProcessDetailByDepartmentManagerIdRes>>> GetAllProcessDetailByDepartmentManagerId(int managerId)
        {
            var process = (await _processRepo.FindAsync(s => s.User.UserId == managerId, int.MaxValue, 1, includeProperties : "VisitProcesses")).ToList();
            if (process.Count == 0)
            {
                return  Result.Failure<ICollection<ProcessDetailByDepartmentManagerIdRes>>(Error.NotFound);
            }

            var res = _mapper.Map<ICollection<ProcessDetailByDepartmentManagerIdRes>>(process);
            return res.ToList();
        }

        public async Task<Result<ICollection<ProcessDetailRes>>> GetProcessDetail(int processId)
        {
            var process = (await _vistProcessRepo.FindAsync(s => s.ProcessId == processId, int.MaxValue, 1)).ToList();
            if (process.Count == 0)
            {
                return Result.Failure<ICollection<ProcessDetailRes>>(Error.NotFound);
            }

            var res = _mapper.Map<ICollection<ProcessDetailRes>>(process);
            return res.ToList();
        }
    }
}
