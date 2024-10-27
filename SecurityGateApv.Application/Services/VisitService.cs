using AutoMapper;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Common;
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
        private readonly IScheduleRepo _scheduleRepo;
        private readonly IScheduleUserRepo _scheduleUserRepo;

        public VisitService(IVisitRepo visitRepo, IMapper mapper, IUnitOfWork unitOfWork, IScheduleTypeRepo visitTypeRepo,
            IVisitDetailRepo visitDetailRepo, IVisitorRepo visitorRepo, IUserRepo userRepo, IScheduleRepo scheduleRepo, IScheduleUserRepo scheduleUserRepo)
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
            _scheduleRepo = scheduleRepo;
            _scheduleUserRepo = scheduleUserRepo;
        }

        public async Task<Result<VisitCreateCommand>> CreateVisit(VisitCreateCommand command)
        {
            var scheduleAssign = (await _scheduleUserRepo.FindAsync(s => s.AssignToId == command.CreateById && s.ScheduleId == command.ScheduleId && s.Status == ScheduleUserStatusEnum.Assigned.ToString())).FirstOrDefault();
            if (scheduleAssign == null)
            {
                return Result.Failure<VisitCreateCommand>(Error.NoScheduleAssignForThisStaff);
            }
            var schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleId == command.ScheduleId, includeProperties: "ScheduleType")).FirstOrDefault();
            var createVisit = Visit.Create(
                command.VisitName,
                command.VisitQuantity,
                command.ExpectedStartTime,
                command.ExpectedStartTime.AddDays(schedule.Duration),
                DateTime.Now,
                DateTime.Now,
                command.Description,
                VisitProcessEnum.Active.ToString(),
                command.CreateById,
                command.ScheduleId,
                command.ResponsiblePersonId
                );
            if (createVisit.IsFailure)
            {
                return Result.Failure<VisitCreateCommand>(createVisit.Error);
            }
            var visit = createVisit.Value;
            foreach (var item in command.VisitDetail)
            {
                var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.Visit.VisitStatus != VisitStatusEnum.Cancel.ToString()
                 && s.Visit.ExpectedEndTime >= command.ExpectedStartTime, int.MaxValue, 1, e => e.OrderBy(z => z.Visit.ExpectedStartTime), "Visit,Visit.Schedule,Visit.Schedule.ScheduleType");

                var addVisitDetailResult = await visit.AddVisitDetailOfOldVisitor(
                    visitorSchedule,
                    schedule,
                    item.ExpectedStartHour,
                    item.ExpectedEndHour,
                    true,
                    item.VisitorId);
                if (addVisitDetailResult.IsFailure)
                {
                    return Result.Failure<VisitCreateCommand>(addVisitDetailResult.Error);
                }
            }
            scheduleAssign.UpdateVisitList();
            await _scheduleUserRepo.UpdateAsync(scheduleAssign);
            await _visitRepo.AddAsync(visit);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<VisitCreateCommand>(Error.CommitError);
            }
            return command;
        }
        public async Task<Result<VisitCreateCommandDaily>> CreateVisitDaily(VisitCreateCommandDaily command)
        {
            var schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.VisitDaily.ToString()), includeProperties: "ScheduleType")).FirstOrDefault();
            var createVisit = Visit.Create(
                command.VisitName,
                command.VisitQuantity,
                command.ExpectedStartTime,
                command.ExpectedStartTime,
                DateTime.Now,
                DateTime.Now,
                command.Description,
                VisitProcessEnum.Active.ToString(),
                command.CreateById,
                6,
                command.ResponsiblePersonId
                );
            if (createVisit.IsFailure)
            {
                return Result.Failure<VisitCreateCommandDaily>(createVisit.Error);
            }
            var visit = createVisit.Value;
            foreach (var item in command.VisitDetail)
            {
                var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.Visit.VisitStatus != VisitStatusEnum.Cancel.ToString()
                    && s.Visit.ExpectedEndTime >= command.ExpectedStartTime, int.MaxValue, 1, e => e.OrderBy(z => z.Visit.ExpectedStartTime), "Visit,Visit.Schedule,Visit.Schedule.ScheduleType");
                var addVisitDetailResult = await visit.AddVisitDetailOfOldVisitor(
                    visitorSchedule,
                    schedule,
                    item.ExpectedStartHour,
                    item.ExpectedEndHour,
                    true,
                    item.VisitorId);
                if (addVisitDetailResult.IsFailure)
                {
                    return Result.Failure<VisitCreateCommandDaily>(addVisitDetailResult.Error);
                }
            }
            await _visitRepo.AddAsync(visit);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<VisitCreateCommandDaily>(Error.CommitError);
            }
            return command;
        }

        public async Task<Result<List<GetVisitNoDetailRes>>> GetAllVisit(int pageSize, int pageNumber)
        {
            var visit = await _visitRepo.FindAsync(s => true, pageSize, pageNumber, s => s.OrderBy(x => x.CreateTime), includeProperties: "CreateBy,UpdateBy,Schedule");
            if (visit.Count() == 0)
            {
                return Result.Failure<List<GetVisitNoDetailRes>>(Error.NotFoundVisit);
            }
            var res = _mapper.Map<List<GetVisitNoDetailRes>>(visit);
            return res;
        }
        public async Task<Result<GetVisitRes>> GetVisitDetailByVisitId(int visitId)
        {
            var visit = await _visitRepo.FindAsync(
                s => s.VisitId == visitId, 1, 1, includeProperties: "VisitDetail,VisitDetail.Visitor,CreateBy,UpdateBy,Schedule"
                );

            if (visit.Count() == 0 || visit == null)
            {
                return Result.Failure<GetVisitRes>(Error.NotFound);
            }
            var visitRes = _mapper.Map<GetVisitRes>(visit.FirstOrDefault());
            return Result.Success(visitRes);
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
                    && s.VisitStatus.Equals(VisitStatusEnum.Started.ToString()),
                    pageSize, pageNumber, includeProperties: "Schedule.ScheduleType,CreateBy"
                );

            if (visit.Count() == 0)
            {
                return Result.Failure<List<GetVisitByDateRes>>(Error.NotFoundVisitCurrentDate);
            }

            var visitResult = new List<Visit>();
            foreach (var item in visit)
            {
                if (IsValidVisit(item, date))
                {
                    visitResult.Add(item);
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
            if (!await _visitRepo.IsAny(s => s.VisitId == visitId))
            {
                return Result.Failure<List<GetVisitDetailRes>>(Error.NotFoundVisit);
            }

            IEnumerable<VisitDetail> visitDetail;
            if (pageNumber <= 0 || pageSize <= 0)
            {
                visitDetail = await _visitDetailRepo.FindAsync(
                        s => s.VisitId == visitId,
                        int.MaxValue, 1,
                        orderBy: s => s.OrderBy(s => s.ExpectedStartHour),
                        includeProperties: "Visitor"
                    );
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
            foreach (var item in visitDetail)
            {
                try
                {
                    item.Visitor.DecrypCredentialCard(await CommonService.Decrypt(item.Visitor.VisitorCredentialImage));
                }
                catch (Exception ex)
                {
                    return Result.Failure<List<GetVisitDetailRes>>(Error.DecryptError);
                }
            }

            var visitRes = _mapper.Map<List<GetVisitDetailRes>>(visitDetail);
            return visitRes;
        }

        public async Task<Result<List<GetVisitByCredentialCardRes>>> GetVisitByCurrentDateAndCredentialCard(string credentialCard, DateTime date)
        {
            var visitDetails = await _visitDetailRepo.FindAsync(
                s => s.Visitor.CredentialsCard.Equals(credentialCard)
                && s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date
                && s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date,
                int.MaxValue, 1, s => s.OrderByDescending(s => s.ExpectedStartHour), "Visit.Schedule.ScheduleType,Visitor"
                );

            if (visitDetails == null || !visitDetails.Any())
            {
                return Result.Failure<List<GetVisitByCredentialCardRes>>(Error.NotFoundVisit);
            }
            var visitResult = new List<VisitDetail>();
            foreach (var item in visitDetails)
            {
                if (IsValidVisit(item.Visit, date))
                {
                    visitResult.Add(item);
                }
            }

            if (visitResult.Count == 0)
            {
                return Result.Failure<List<GetVisitByCredentialCardRes>>(Error.NotFoundVisit);
            }
            var result = _mapper.Map<List<GetVisitByCredentialCardRes>>(visitResult);

            return result;
        }
        private bool IsValidVisit(Visit visit, DateTime date)
        {
            string[] daysOfSchedule = visit.Schedule.DaysOfSchedule.Split(',');
            int dateOfWeekInput = ((int)date.DayOfWeek == 0) ? 7 : (int)date.DayOfWeek;
            if (visit.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.VisitDaily.ToString()))
            {
                return true;
            }
            if (visit.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessWeek.ToString())
                && daysOfSchedule.Contains(dateOfWeekInput.ToString()))
            {
                return true;
            }
            if (visit.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessMonth.ToString())
                && daysOfSchedule.Contains(date.Day.ToString()))
            {
                return true;
            }
            return false;
        }
        public async Task<Result<VisitCreateCommand>> UpdateVisit(int visitId, VisitCreateCommand command)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId, includeProperties: "VisitDetail")).FirstOrDefault();
            if (visit == null)
            {
                return Result.Failure<VisitCreateCommand>(Error.NotFoundVisit);
            }

            var schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleId == command.ScheduleId, includeProperties: "ScheduleType")).FirstOrDefault();
            await _visitDetailRepo.RemoveRange(visit.VisitDetail);
            visit.AddEndTime(schedule.Duration);

            visit.RemoveDetail();
            foreach (var item in command.VisitDetail)
            {
                var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.VisitId != visitId &&
                    s.Visit.ExpectedEndTime >= command.ExpectedStartTime, int.MaxValue, 1, e => e.OrderByDescending(z => z.Visit.ExpectedStartTime), "Visit,Visit.Schedule,Visit.Schedule.ScheduleType");

                var addVisitDetailResult = await visit.AddVisitDetailOfOldVisitor(
                    visitorSchedule,
                    schedule,
                    item.ExpectedStartHour,
                    item.ExpectedEndHour,
                    true,
                    item.VisitorId);
                if (addVisitDetailResult.IsFailure)
                {
                    return Result.Failure<VisitCreateCommand>(addVisitDetailResult.Error);
                }
            }

            visit = _mapper.Map(command, visit);
            visit.Update(command.CreateById);
            await _visitRepo.UpdateAsync(visit);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<VisitCreateCommand>(Error.CommitError);
            }

            return command;
        }

        public Task<Result<bool>> DeleteVisit(int visitId)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByCreateById(int createById, int pageNumber, int pageSize)
        {
            var visit = (await _visitRepo.FindAsync(s => s.CreateById == createById, pageSize, pageNumber, s => s.OrderByDescending(x => x.CreateTime), includeProperties: "CreateBy,UpdateBy,Schedule")).ToList();
            if (visit == null)
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.NotFoundVisit);
            }
            var visitRes = _mapper.Map<IEnumerable<GetVisitRes>>(visit);
            return visitRes.ToList();
        }

        public async Task<Result<IEnumerable<GetVisitRes>>> GetVisitByDepartmentId(int departmentId, int pageNumber, int pageSize)
        {
            var visit = (await _visitRepo.FindAsync(s => s.CreateBy.DepartmentId == departmentId, pageSize, pageNumber, s => s.OrderByDescending(x => x.ExpectedStartTime), includeProperties: "CreateBy,UpdateBy,Schedule")).ToList();
            if (visit.Count == 0)
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.NotFoundVisit);
            }
            var visitRes = _mapper.Map<IEnumerable<GetVisitRes>>(visit);
            return visitRes.ToList();
        }
        public async Task<Result<IEnumerable<GetVisitRes>>> GetVisitByUserId(int userId, int pageNumber, int pageSize)
        {
            var user = (await _userRepo.FindAsync(
                    s => s.UserId == userId, includeProperties: "Role"
                )).FirstOrDefault();
            if (user == null)
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.NotFoundUser);
            }
            List<Visit> visit;

            if (user.Role.RoleName.Equals(UserRoleEnum.Admin.ToString()) ||
                user.Role.RoleName.Equals(UserRoleEnum.Manager.ToString()))
            {
                visit = (await _visitRepo.FindAsync(s => true,
                    pageSize,
                    pageNumber,
                    s => s.OrderByDescending(x => x.CreateTime),
                    includeProperties: "CreateBy,UpdateBy,Schedule")).ToList();
            }
            else if (user.Role.RoleName.Equals(UserRoleEnum.DepartmentManager.ToString()))
            {
                var staffIds = (await _userRepo.FindAsync(
                        s => s.DepartmentId == user.DepartmentId,
                        int.MaxValue, 1
                        )).Select(s => s.UserId).ToList();

                visit = (List<Visit>)await _visitRepo.FindAsync(
                        s => staffIds.Contains(s.CreateById),
                        pageSize,
                        pageNumber,
                        s => s.OrderByDescending(x => x.CreateTime),
                        includeProperties: "CreateBy,UpdateBy,Schedule");
            }
            else if (user.Role.RoleName.Equals(UserRoleEnum.Staff.ToString()) ||
                    user.Role.RoleName.Equals(UserRoleEnum.Security.ToString()))
            {

                visit = (List<Visit>)await _visitRepo.FindAsync(
                        s => s.CreateById == userId,
                        pageSize,
                        pageNumber,
                        s => s.OrderByDescending(x => x.CreateTime),
                        includeProperties: "CreateBy,UpdateBy,Schedule");
            }
            else
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.Unauthorized);
            }
            var visitRes = _mapper.Map<IEnumerable<GetVisitRes>>(visit);

            return Result.Success(visitRes);
        }

        public async Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByStatus(string status, int pageNumber, int pageSize)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitStatus.Equals(status), pageSize, pageNumber, s => s.OrderByDescending(x => x.CreateTime), includeProperties: "CreateBy,UpdateBy,Schedule")).ToList();
            if (visit == null)
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.NotFoundVisit);
            }
            var visitRes = _mapper.Map<IEnumerable<GetVisitRes>>(visit);
            return visitRes.ToList();
        }
    }
}
