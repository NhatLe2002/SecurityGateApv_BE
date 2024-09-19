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
        private readonly IUnitOfWork _unitOfWork;
        public VisitService(IVisitRepo visitRepo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _visitRepo = visitRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<bool>> CreateVisit(VisitCreateCommand command)
        {
            var createvisit = Visit.Create(command.VisitQuantity,
                command.AcceptLevel,
                command.DepartmentReasonId,
                command.CreateById,
                command.UpdateById
                );
            if (createvisit.IsFailure)
            {
                return Result.Failure<bool>(createvisit.Error);
            }
            var visit = createvisit.Value;

            foreach (var item in command.VisitDetailOfOldVisitor)
            {
                visit.AddVisitDetailOfOldVisitor(item.VisitDetailName,
                    item.Description,
                    item.ExpectedTimeIn,
                    item.ExpectedTimeOut,
                    item.Status,
                    item.VisitorId);
            }

            List<Visitor> newVisitor = new();
            var inforNewVisitor = command.VisitDetailOfNewVisitor.Select(s => s.Visitor).ToList();
            foreach(var item in inforNewVisitor)
            {
                var createVisitor = Visitor.Create(item.VisitorName,
                    item.CompanyName,
                    item.PhoneNumber,
                    DateTime.Now,
                    DateTime.Now,
                    item.CredentialsCard,
                    item.Status,
                    item.CredentialCardTypeId
                    );
                if (createVisitor.IsFailure)
                {
                    return Result.Failure<bool>(createVisitor.Error);
                }
                newVisitor.Add(createVisitor.Value);
            }

            var t = 0;
            foreach (var item in command.VisitDetailOfNewVisitor)
            {
                visit.AddVisitDetailOfNewVisitor(item.VisitDetailName,
                    item.Description,
                    item.ExpectedTimeIn,
                    item.ExpectedTimeOut,
                    item.Status,
                    newVisitor[t]);
                t++;
            }
            await _visitRepo.AddAsync(visit);

            await _unitOfWork.CommitAsync();
            return true;
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

        public async Task<Result<GetVisitRes>> GetVisitDetailByVisitId(int visitId)
        {
            var visit = await _visitRepo.FindAsync(
                s => s.VisitId == visitId, 1, 1, includeProperties: "VisitDetail,VisitDetail.Visitor"
                );

            if (visit == null)
            {
                return Result.Failure<GetVisitRes>(Error.NotFound); 
            }
            var visitRes = _mapper.Map<GetVisitRes>(visit.FirstOrDefault());

            return Result.Success(visitRes);
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
