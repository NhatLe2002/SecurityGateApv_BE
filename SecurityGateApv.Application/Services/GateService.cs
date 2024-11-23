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
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public GateService( IMapper mapper, IUnitOfWork unitOfWork, IGateRepo gateRepo)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _gateRepo = gateRepo;
        }

        public Task<Result<bool>> CreateCard(CreateGateCommand command)
        {
            throw new NotImplementedException();
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
                pageNumber
               );
            if (gate == null)
            {
                return Result.Failure<List<GetGateRes>> (Error.NotFound);
            }
            var result = _mapper.Map<List<GetGateRes>>(gate);
            return Result.Success(result);

        }
    }
}
