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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SecurityGateApv.Application.Services
{
    public class VisitService : IVisitService
    {
        private readonly IVisitRepo _visitRepo;
        private readonly IVisitorRepo _visitorRepo;
        private readonly IVisitDetailRepo _visitDetailRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVisitTypeRepo _visitTypeRepo;
        private readonly IUserRepo _userRepo;
        private readonly IVistProcessRepo _vistProcessRepo;

        public VisitService(IVisitRepo visitRepo, IMapper mapper, IUnitOfWork unitOfWork, IVisitTypeRepo visitTypeRepo, IUserRepo userRepo, IVistProcessRepo visitProcessRepo)
        {
            _visitRepo = visitRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _visitTypeRepo = visitTypeRepo;
            _userRepo = userRepo;
            _vistProcessRepo = visitProcessRepo;
            _visitDetailRepo = visitDetailRepo;
            _visitorRepo = visitorRepo;
        }

        public async Task<Result<VisitCreateCommand>> CreateVisit(VisitCreateCommand command)
        {

            var visitCreate = await NewVisit(VisitTypeEnum.NONE, command, null);
            if (visitCreate.IsFailure)
            {
                return Result.Failure<VisitCreateCommand>(visitCreate.Error);
            }
            await _visitRepo.AddAsync(visitCreate.Value);

            await _unitOfWork.CommitAsync();
            return command;
        }
        private async Task<Result<Visit>> NewVisit(VisitTypeEnum visitType, VisitCreateCommand command, VisitProcess visitProcess)
        {
            var createPerson = (await _userRepo.FindAsync(s => s.UserId == command.CreateById, includeProperties: "Role")).FirstOrDefault();
            var visit = new Visit();
            if(visitType != VisitTypeEnum.NONE)
            {
                var createvisit = Visit.CreateVisitOfProcess(command.VisitQuantity,
                    command.AcceptLevel,
                    command.VisitName,
                    command.CreateById,
                    command.UpdateById,
                    visitType
                );
                if (createvisit.IsFailure)
                {
                    return Result.Failure<Visit>(createvisit.Error);
                }
                visit = createvisit.Value;
            }
            else
            {
                var createvisit = Visit.Create(command.VisitQuantity,
                    command.AcceptLevel,
                    command.VisitName,
                    command.CreateById,
                    command.UpdateById,
                    createPerson
                );
                if (createvisit.IsFailure)
                {
                    return Result.Failure<Visit>(createvisit.Error);
                }
                visit = createvisit.Value;
            }


            foreach (var item in command.VisitDetailOfOldVisitor)
            {
                visit.AddVisitDetailOfOldVisitor(
                    item.Description,
                    visitProcess.ExpectedStartDate,
                    visitProcess.ExpectedEndDate,
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
                    item.CreateById,
                    DateTime.Now,
                    DateTime.Now,
                    item.CredentialsCard,
                    item.Status,
                    item.CredentialCardTypeId
                    );
                if (createVisitor.IsFailure)
                {
                    return Result.Failure<Visit>(createVisitor.Error);
                }
                newVisitor.Add(createVisitor.Value);
            }

            var t = 0;
            foreach (var item in command.VisitDetailOfNewVisitor)
            {
                visit.AddVisitDetailOfNewVisitor(
                    item.Description,
                    visitProcess.ExpectedStartDate,
                    visitProcess.ExpectedEndDate,
                    item.ExpectedTimeIn,
                    item.ExpectedTimeOut,
                    item.Status,
                    newVisitor[t]);
                t++;
            }
            return visit;
        }
        public async Task<Result<VisitCreateCommand>> CreateVisitOfProcess(int processVisitId, VisitCreateCommand command, bool visitType) //true is for process, false for project
        {
            var processVisit = (await _vistProcessRepo.FindAsync(s => s.VisitProcessId == processVisitId)).FirstOrDefault();
            var visit = new Visit();

            if (visitType)
            {
                
                var createvisit = await NewVisit(VisitTypeEnum.ProcessWeek, command, processVisit);
                if (createvisit.IsFailure)
                {
                    return Result.Failure<VisitCreateCommand>(createvisit.Error);
                }
                visit = createvisit.Value;
            }
            else
            {
                var createvisit = await NewVisit(VisitTypeEnum.Project, command, processVisit);

                if (createvisit.IsFailure)
                {
                    return Result.Failure<VisitCreateCommand>(createvisit.Error);
                }
                visit = createvisit.Value;
            }

            processVisit.AddVisitToProcess(visit);

            await _vistProcessRepo.UpdateAsync(processVisit);
            await _unitOfWork.CommitAsync();

            return command;
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
                s => s.ExpectedStartDate.Date <= DateTime.Now.Date ,
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
