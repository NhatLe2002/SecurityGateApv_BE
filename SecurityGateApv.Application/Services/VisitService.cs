using AutoMapper;
using SecurityGateApv.Application.DTOs.Req;
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
    public class VisitService : IVisitService
    {
        private readonly IVisitRepo _visitRepo;
        private readonly IMapper _mapper;
        public VisitService(IVisitRepo visitRepo, IMapper mapper)
        {
            _visitRepo = visitRepo;
            _mapper = mapper;
        }

        public async Task<Result<List<GetVisitRes>>> GetAllByFilterOrderbyIncludePaging(QueryParameters<Visit> queryParameters)
        {
            var visits = await _visitRepo.GetAllByFilterOrderbyIncludePaging(
                queryParameters.Filter,
                queryParameters.OrderBy,
                queryParameters.IncludeProperties,
                queryParameters.PageIndex,
                queryParameters.PageSize
                );
            var visitRes = _mapper.Map<List<GetVisitRes>>(visits);
            return Result.Success(visitRes);
        }

        public async Task<Result<List<GetVisitRes>>> GetAllByPaging(int pageNumber, int pageSize)
        {
            var visits = await _visitRepo.FindAsync(
                s => true, pageSize, pageNumber, s => s.OrderBy(s=>s.DateRegister), ""
                );
            var result = _mapper.Map<List<GetVisitRes>>(visits);
            if(result.Count == 0)
            {
                return Result.Failure<List<GetVisitRes>>(Error.NotFoundVisit);
            }
            return result;
        }

        public async Task<Result<List<GetVisitRes>>> GetAllVisit()
        {
            var visit = await _visitRepo.GetAllAsync();
            var res = _mapper.Map<List<GetVisitRes>>(visit);
            return res;
        }
        /* public async Task<Result<GetVisitRes>> GetAllVisit()
{
    var visit = await _visitRepo.GetAllVisitIncludeVisitor();
    var result = new List<GetVisitRes>();
    foreach (var item in visit)
    {
        result.Add(new GetVisitRes
        {
            DateRegis = item.DateRegister,
            VisitQuantity = item.VisitQuantity,
            AcceptLevel = item.AcceptLevel,
            VisitDetails = item.VisitDetail,
        });
    }


}*/
    }
}
