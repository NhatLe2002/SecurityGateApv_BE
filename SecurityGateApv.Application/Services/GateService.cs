using AutoMapper;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
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
    public class GateService : IGateService
    {
        private readonly IGateRepo _gateRepo;
        private readonly ICameraRepo _cameraRepo;
        private readonly ICameraTypeRepo _cameraTypeRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public GateService( IMapper mapper, IUnitOfWork unitOfWork, IGateRepo gateRepo, ICameraRepo cameraRepo, ICameraTypeRepo cameraTypeRepo)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _gateRepo = gateRepo;
            _cameraRepo = cameraRepo;
            _cameraTypeRepo = cameraTypeRepo;
        }

        public async Task<Result<bool>> CreateGate(CreateGateCommand command)
        {
            
            var gate =  Gate.Create(command.GateName,DateTime.Now,command.Description,true).Value;
            foreach(var item in command.Cameras)
            {
                var cameraType = await _cameraTypeRepo.GetByIdAsync(item.CameraTypeId);
                if (cameraType == null)
                {
                    return Result.Failure<bool>(Error.NotFound);
                }
                gate.AddCamera(item.CaptureURL, item.StreamURL, item.Description, true, item.CameraTypeId);
            }


            await _gateRepo.AddAsync(gate);
            if(!await _unitOfWork.CommitAsync())
            {
                return Result.Failure<bool>(Error.CommitError);
            }

            return Result.Success(true);
        }

        public async Task<Result<List<CameraTypeRes>>> GetAllCameraType()
        {
            var cameraType = await _cameraTypeRepo.GetAllAsync();
            var res = _mapper.Map<List<CameraTypeRes>>(cameraType);
            return res;
        }

        public async Task<Result<List<GetGateRes>>> GetAllGate()
        {
            var gate = await _gateRepo.GetAllAsync();
            var res = _mapper.Map<List<GetGateRes>>(gate);
            return res;
        }

        public async Task<Result<List<GetGateRes>>> GetAllGatePaging(int pageSize, int pageNumber)
        {
            var gate = await _gateRepo.FindAsync(
                s => true,
                pageSize,
                pageNumber,
                includeProperties : "Cameras"
               );
            if (gate == null)
            {
                return Result.Failure<List<GetGateRes>> (Error.NotFound);
            }
            var result = _mapper.Map<List<GetGateRes>>(gate);
            return Result.Success(result);

        }

        public async Task<Result<List<CameraRes>>> GetCameraByGate(int gate)
        {
            var camera = await _cameraRepo.FindAsync(
                    s => s.GateId == gate,
                    includeProperties: "CameraType"
                );
            var res = _mapper.Map<List<CameraRes>>(camera);
            return res;
        }
    }
}
