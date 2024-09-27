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
        private readonly IVisitorRepo _visitorRepo;
        private readonly IVisitDetailRepo _visitDetailRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public VisitService(IVisitRepo visitRepo, IMapper mapper, IUnitOfWork unitOfWork, IVisitDetailRepo visitDetailRepo, IVisitorRepo visitorRepo)
        {
            _visitRepo = visitRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _visitDetailRepo = visitDetailRepo;
            _visitorRepo = visitorRepo;
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
            foreach (var item in inforNewVisitor)
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

        public async Task<Result<List<GetVisitNoDetailRes>>> GetAllByPaging(int pageNumber, int pageSize)
        {
            var visits = await _visitRepo.FindAsync(
                s => true, pageSize, pageNumber, s => s.OrderBy(s => s.DateRegister), "CreateBy"
                );
            var result = _mapper.Map<List<GetVisitNoDetailRes>>(visits);
            
            if (result.Count == 0)
            {
                return Result.Failure<List<GetVisitNoDetailRes>>(Error.NotFoundVisit);
            }
            return result;
        }

        public async Task<Result<List<GetVisitNoDetailRes>>> GetAllVisit()
        {
            var visit = await _visitRepo.GetAllAsync();
            var res = _mapper.Map<List<GetVisitNoDetailRes>>(visit);
            return res;
        }

        public async Task<Result<List<GetVisitByCurrentDateRes>>> GetVisitByCurrentDate(int pageSize, int pageNumber)
        {
            var visitDetails = await _visitDetailRepo.FindAsync(
                s => s.ExpectedStartDate.Date == DateTime.Now.Date,
                pageSize, pageNumber, s => s.OrderBy(s => s.ExpectedStartTime), "Visit,Visitor"
                );
            var result = new List<GetVisitByCurrentDateRes>();
            foreach (var item in visitDetails)
            {
                result.Add(new GetVisitByCurrentDateRes
                {
                    VisitId = item.VisitId,
                    VisitDetailId = item.VisitDetailId,
                    VisitName = item.Visit.VisitName,
                    ExpectedStartDate = item.ExpectedStartDate,
                    ExpectedEndDate = item.ExpectedEndDate,
                    ExpectedStartTime = item.ExpectedStartTime,
                    ExpectedEndTime = item.ExpectedEndTime,
                    VisitorName = item.Visitor.VisitorName,
                    CompanyName = item.Visitor.CompanyName,
                    PhoneNumber = item.Visitor.PhoneNumber,
                    CredentialsCard = item.Visitor.CredentialsCard,
                });
            }

            if (result.Count == 0)
            {
                return Result.Failure<List<GetVisitByCurrentDateRes>>(Error.NotFoundVisit);
            }
            return result;
        }

        public async Task<Result<GetVisitRes>> GetVisitDetailByVisitId(int visitId)
        {
            var visit = await _visitRepo.FindAsync(
                s => s.VisitId == visitId, 1, 1, includeProperties: "VisitDetail,VisitDetail.Visitor,VisitProcess"
                );

            if (visit == null)
            {
                return Result.Failure<GetVisitRes>(Error.NotFound);
            }
            var visitRes = _mapper.Map<GetVisitRes>(visit.FirstOrDefault());
            visitRes.DaysOfProcess = visit.FirstOrDefault().VisitProcess.FirstOrDefault().DaysOfProcess;
            return Result.Success(visitRes);
        }

        public async Task<Result<List<GetVisitByCurrentDateRes>>> GetVisitByCredentialCard(string credentialCard)
        {
            var visitDetails = await _visitDetailRepo.FindAsync(
                s => s.Visitor.CredentialsCard.Equals(credentialCard) && s.ExpectedStartDate <= DateTime.Now && s.ExpectedEndDate >= DateTime.Now,
                10, 1, s => s.OrderBy(s => s.ExpectedStartTime), "Visit,Visitor"
                );


            if (visitDetails == null || !visitDetails.Any())
            {
                return Result.Failure<List<GetVisitByCurrentDateRes>>(Error.NotFoundVisit);
            }
            var result = new List<GetVisitByCurrentDateRes>();
            foreach (var item in visitDetails)
            {
                result.Add(new GetVisitByCurrentDateRes
                {
                    VisitDetailId = item.VisitDetailId,
                    VisitId = item.VisitId,
                    VisitName = item.Visit.VisitName,
                    ExpectedStartDate = item.ExpectedStartDate,
                    ExpectedEndDate = item.ExpectedEndDate,
                    ExpectedStartTime = item.ExpectedStartTime,
                    ExpectedEndTime = item.ExpectedEndTime,
                    VisitorName = item.Visitor.VisitorName,
                    CompanyName = item.Visitor.CompanyName,
                    PhoneNumber = item.Visitor.PhoneNumber,
                    CredentialsCard = item.Visitor.CredentialsCard,
                });
            }

            return Result.Success(result);
        }

    }
}
