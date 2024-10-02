using AutoMapper;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Interfaces.Common;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services
{
    public class VisitorService : IVisitorService
    {
        private readonly IVisitorRepo _visitorRepo;
        private readonly ICommonService _commonService;
        private readonly IMapper _mapper;

        public VisitorService(IVisitorRepo visitorRepo, ICommonService commonService, IMapper mapper)
        {
            _visitorRepo = visitorRepo;
            _commonService = commonService;
            _mapper = mapper;

        }
        public async Task<Result<CreateVisitorCommand>> CreateVisitor(CreateVisitorCommand command)
        {
            var imageString = await _commonService.ImageToBase64(command.VisitorCredentialImage);

            return command;
        }

        public Task<Result<List<bool>>> DeleteVisitor(int visitorId)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<List<GetVisitorRes>>> GetAllByPaging(int pageNumber, int pageSize)
        {
            var list = await _visitorRepo.GetAllAsync();
            return _mapper.Map<List<GetVisitorRes>>(list);
        }

        public Task<Result<GetVisitorRes>> GetById(int visitorId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<CreateVisitorCommand>>> UpdateVisitor(int visitorId, CreateVisitorCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
