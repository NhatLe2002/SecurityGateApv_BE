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
        private readonly IScheduleTypeRepo _visitTypeRepo;
        private readonly IUserRepo _userRepo;

        public VisitService(IVisitRepo visitRepo, IMapper mapper, IUnitOfWork unitOfWork, IScheduleTypeRepo visitTypeRepo,
            IVisitDetailRepo visitDetailRepo, IVisitorRepo visitorRepo, IUserRepo userRepo)
        {
            _visitRepo = visitRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _visitDetailRepo = visitDetailRepo;
            _visitorRepo = visitorRepo;
            _visitTypeRepo = visitTypeRepo;
            _userRepo = userRepo;
            _visitDetailRepo = visitDetailRepo;
            _visitorRepo = visitorRepo;
        }

        public async Task<Result<VisitCreateCommand>> CreateVisit(VisitCreateCommand command)
        {

            var visitCreate = await NewVisit(ScheduleTypeEnum.NONE, command);
            if (visitCreate.IsFailure)
            {
                return Result.Failure<VisitCreateCommand>(visitCreate.Error);
            }
            await _visitRepo.AddAsync(visitCreate.Value);

            await _unitOfWork.CommitAsync();
            return command;
        }
        private async Task<Result<Visit>> NewVisit(ScheduleTypeEnum visitType, VisitCreateCommand command)
        {
            /* var createPerson = (await _userRepo.FindAsync(s => s.UserId == command.CreateById, includeProperties: "Role")).FirstOrDefault();
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
             return visit;*/
            return null;
        }
        public async Task<Result<VisitCreateCommand>> CreateVisitOfProcess(int processVisitId, VisitCreateCommand command, bool visitType) //true is for process, false for project
        {
            /*var processVisit = (await _vistProcessRepo.FindAsync(s => s.VisitProcessId == processVisitId)).FirstOrDefault();
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

            return command;*/
            return null;
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
                s => true, pageSize, pageNumber, s => s.OrderBy(s => s.ExpectedStartTime), "CreateBy"
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

        public async Task<Result<List<GetVisitByDateRes>>> GetVisitByDate(int pageSize, int pageNumber, DateTime date)
        {
            var visit = await _visitRepo.FindAsync(
                    s => s.ExpectedStartTime.Date <= date.Date
                    && s.ExpectedEndTime.Date >= date.Date
                    && s.VisitStatus.Equals(VisitStatusEnum.Active.ToString()),
                    pageSize, pageNumber, includeProperties: "Schedule.ScheduleType"
                );
            var visitResult = new List<Visit>();
            if(visit.Count() == 0)
            {
                return Result.Failure<List<GetVisitByDateRes>>(Error.NotFoundVisitCurrentDate);
            }
            foreach( var item in visit)
            {
                if (item.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.VisitDaily.ToString()))
                {
                    visitResult.Add(item);
                }
                string[] daysOfSchedule = item.Schedule.DaysOfSchedule.Split(',');
                int dateOfWeekInput = ((int) date.DayOfWeek == 0) ? 7 : (int)date.DayOfWeek;

                if (item.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessWeek.ToString()) 
                    && daysOfSchedule.Contains(dateOfWeekInput.ToString()))
                {
                    visitResult.Add(item);
                }

                if (item.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessMonth.ToString()))
                {
                    if (daysOfSchedule.Contains(date.Day.ToString()))
                    {
                        visitResult.Add(item);
                    }
                }
            }

            if (visitResult.Count == 0)
            {
                return Result.Failure<List<GetVisitByDateRes>>(Error.NotFoundVisit);
            }

            var result = _mapper.Map<List<GetVisitByDateRes>>(visitResult);

            return result;
        }

        public async Task<Result<List<GetVisitDetailRes>>> GetVisitDetailByVisitId(int visitId, int pageNumber, int pageSize)
        {
            if (! await _visitRepo.IsAny(s => s.VisitId == visitId))
            {
                return Result.Failure<List<GetVisitDetailRes>>(Error.NotFoundVisit);
            }

            IEnumerable<VisitDetail> visitDetail;
            if (pageNumber <= 0 || pageSize <= 0)
            {
                visitDetail = await _visitDetailRepo.GetAllAsync();
            }
            else
            {
                visitDetail = await _visitDetailRepo.FindAsync(
                        s => s.VisitId == visitId,
                        pageSize, pageNumber,
                        orderBy: s => s.OrderBy(s => s.ExpectedStartHour),
                        includeProperties: "Visitor"
                    );
            }

            if (visitDetail == null)
            {
                return Result.Failure<List<GetVisitDetailRes>>(Error.NotFoundVisitDetail);
            }

            var visitRes = _mapper.Map<List<GetVisitDetailRes>>(visitDetail);
            return visitRes;
        }

       /* public async Task<Result<List<GetVisitByCurrentDateRes>>> GetVisitByCredentialCard(string credentialCard)
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
                    //CompanyName = item.Visitor.CompanyName,
                    PhoneNumber = item.Visitor.PhoneNumber,
                    CredentialsCard = item.Visitor.CredentialsCard,
                });
            }

            return Result.Success(result);
            return null;
        }
*/
        public Task<Result<List<GetVisitByDateRes>>> GetVisitByCredentialCard(string credentialCard)
        {
            throw new NotImplementedException();
        }
    }
}
