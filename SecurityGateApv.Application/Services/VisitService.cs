using AutoMapper;
using Microsoft.VisualBasic;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Common;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.EmailSender;
using SecurityGateApv.Domain.Interfaces.Jwt;
using SecurityGateApv.Domain.Interfaces.Notifications;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Error = SecurityGateApv.Domain.Errors.Error;

namespace SecurityGateApv.Application.Services
{
    public class VisitService : IVisitService
    {
        private readonly IVisitRepo _visitRepo;
        private readonly IVisitorRepo _visitorRepo;
        private readonly IVisitDetailRepo _visitDetailRepo;
        private readonly IVisitorSessionRepo _visitorSessionRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IScheduleTypeRepo _visitTypeRepo;
        private readonly IUserRepo _userRepo;
        private readonly IScheduleRepo _scheduleRepo;
        private readonly IScheduleUserRepo _scheduleUserRepo;
        private readonly INotifications _notifications;
        private readonly INotificationRepo _notificationRepo;
        private readonly IJwt _jwt;
        private readonly IEmailSender _emailSender;

        public VisitService(IVisitRepo visitRepo, IMapper mapper, IUnitOfWork unitOfWork, IScheduleTypeRepo visitTypeRepo,
            IVisitDetailRepo visitDetailRepo, IVisitorRepo visitorRepo, IUserRepo userRepo, IScheduleRepo scheduleRepo,
            IScheduleUserRepo scheduleUserRepo, IJwt jwt, INotifications notifications, INotificationRepo notificationRepo, IEmailSender emailSender)
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
            _jwt = jwt;
            _notifications = notifications;
            _notificationRepo = notificationRepo;
            _emailSender = emailSender;
        }

        public async Task<Result<VisitCreateCommand>> CreateVisit(VisitCreateCommand command, string token)
        {
            var role = _jwt.DecodeJwt(token);
            var scheduleAssign = (await _scheduleUserRepo.FindAsync(s => s.AssignToId == command.CreateById && s.Id == command.ScheduleUserId && s.Status == ScheduleUserStatusEnum.Assigned.ToString())).FirstOrDefault();
            if (scheduleAssign == null)
            {
                return Result.Failure<VisitCreateCommand>(Error.NoScheduleAssignForThisStaff);
            }
            var schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleUser.Any(t => t.Id == command.ScheduleUserId), includeProperties: "ScheduleType")).FirstOrDefault();

            var createVisit = Visit.Create(
                command.VisitName,
                command.VisitQuantity,
                command.ExpectedStartTime,
                command.ExpectedEndTime,
                DateTime.Now,
                DateTime.Now,
                command.Description,
                 VisitStatusEnum.Pending.ToString(),
                command.CreateById,
                command.ResponsiblePersonId,
                command.ScheduleUserId
                );
            if (createVisit.IsFailure)
            {
                return Result.Failure<VisitCreateCommand>(createVisit.Error);
            }
            var visit = createVisit.Value;
            foreach (var item in command.VisitDetail)
            {
                var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.Visit.VisitStatus != VisitStatusEnum.Cancelled.ToString()
                 && s.Visit.ExpectedEndTime >= command.ExpectedStartTime, int.MaxValue, 1, e => e.OrderBy(z => z.Visit.ExpectedStartTime), "Visit,Visit.ScheduleUser,Visit.ScheduleUser.Schedule,Visit.ScheduleUser.Schedule.ScheduleType");

                var addVisitDetailResult = await visit.AddVisitDetailOfOldVisitor(
                    visitorSchedule,
                    scheduleAssign,
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
            //send email to visitor
            var staff = (await _userRepo.FindAsync(s => s.UserId == command.ResponsiblePersonId)).FirstOrDefault();
            foreach (var item in command.VisitDetail)
            {
                try
                {
                    var visitor = (await _visitorRepo.FindAsync(s => s.VisitorId == item.VisitorId)).FirstOrDefault();
                    if (visitor.Email != null)
                    {
                        await _emailSender.SendEmailAsync(visitor.Email, "APV security", $"Bạn có cuộc hẹn từ công ty APV từ ngày: {visit.ExpectedStartTime} - {visit.ExpectedEndTime}, chi tiết xin liên hệ nhân viên {staff.FullName}");
                    }
                }
                catch
                {

                }
            }
            var createStaff = (await _userRepo.FindAsync(s => s.UserId == command.CreateById)).FirstOrDefault();
            var departmentManager = (await _userRepo.FindAsync(s => s.DepartmentId == createStaff.DepartmentId && s.Role.RoleName == UserRoleEnum.DepartmentManager.ToString())).FirstOrDefault();
            var noti = Notification.Create($"Chuyến thăm cần duyệt từ Nhân Viên: {createStaff.FullName}", "Cần duyệt chuyến thăm cho khách", visit.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
            noti.Value.AddUserNoti(command.CreateById, departmentManager.UserId);
            await _notificationRepo.AddAsync(noti.Value);
            var commit2 = await _unitOfWork.CommitAsync();
            if (!commit2)
            {
                return Result.Failure<VisitCreateCommand>(Error.CommitError);
            }
            await _notifications.SendMessageAssignForStaff($"Chuyến thăm cần duyệt từ Nhân Viên: {createStaff.FullName}", "Cần duyệt chuyến thăm cho khách", departmentManager.UserId, 1);
            return command;
        }
        public async Task<Result<VisitCreateCommandDaily>> CreateVisitDaily(VisitCreateCommandDaily command, string token)
        {
            var role = _jwt.DecodeJwt(token);
            var schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.VisitDaily.ToString()), includeProperties: "ScheduleType")).FirstOrDefault();
            var createVisit = Visit.Create(
                command.VisitName,
                command.VisitQuantity,
                command.ExpectedStartTime,
                command.ExpectedStartTime,
                DateTime.Now,
                DateTime.Now,
                command.Description,
                role == UserRoleEnum.Security.ToString() ? VisitStatusEnum.ActiveTemporary.ToString() : VisitStatusEnum.Active.ToString(),
                command.CreateById,
                command.ResponsiblePersonId,
                null
                );
            if (createVisit.IsFailure)
            {
                return Result.Failure<VisitCreateCommandDaily>(createVisit.Error);
            }
            var visit = createVisit.Value;
            foreach (var item in command.VisitDetail)
            {
                var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.Visit.VisitStatus != VisitStatusEnum.Cancelled.ToString()
                    && s.Visit.ExpectedEndTime.Date >= command.ExpectedStartTime.Date, int.MaxValue, 1, e => e.OrderBy(z => z.Visit.ExpectedStartTime), "Visit.ScheduleUser,Visit.ScheduleUser.Schedule,Visit.ScheduleUser.Schedule.ScheduleType");
                var addVisitDetailResult = await visit.AddVisitDetailOfOldVisitor(
                    visitorSchedule,
                    null,
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
            foreach (var item in command.VisitDetail)
            {
                try
                {
                    var visitor = (await _visitorRepo.FindAsync(s => s.VisitorId == item.VisitorId)).FirstOrDefault();
                    if (visitor.Email != null)
                    {
                        await _emailSender.SendEmailAsync(visitor.Email, "APV security", $"Bạn có cuộc hẹn từ công ty APV vào ngày: {visit.ExpectedStartTime}, thời gian: {item.ExpectedStartHour} - {item.ExpectedEndHour}");
                    }
                }
                catch
                {

                }
            }
            if (role == UserRoleEnum.Security.ToString())
            {
                var user = (await _userRepo.FindAsync(s => s.UserId == command.CreateById)).FirstOrDefault();
                var noti = Notification.Create($"Chuyến thăm xác nhận từ bảo vệ: {user.FullName}", "Cần xác nhận chuyến thăm cho khách", visit.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
                noti.Value.AddUserNoti(command.CreateById, command.ResponsiblePersonId);
                await _notificationRepo.AddAsync(noti.Value)    ;
                var commit2 = await _unitOfWork.CommitAsync();
                if (!commit2)
                {
                    return Result.Failure<VisitCreateCommandDaily>(Error.CommitError);
                }
                await _notifications.SendMessageAssignForStaff($"Chuyến thăm xác nhận từ bảo vệ: {user.FullName}", "Cần xác nhận chuyến thăm cho khách", command.ResponsiblePersonId, 1);
            }
            return command;
        }

        public async Task<Result<List<GetVisitNoDetailRes>>> GetAllVisit(int pageSize, int pageNumber)
        {
            var visits = await _visitRepo.FindAsync(
                       s => true,
                       pageSize,
                       pageNumber,
                       s => s.OrderByDescending(x => x.CreateTime),
                       includeProperties: "CreateBy,UpdateBy,ResponsiblePerson,ScheduleUser,ScheduleUser.Schedule.ScheduleType,VisitDetail.VisitorSession"
                   );

            if (!visits.Any())
            {
                return Result.Failure<List<GetVisitNoDetailRes>>(Error.NotFoundVisit);
            }

            var res = _mapper.Map<List<GetVisitNoDetailRes>>(visits);

            foreach (var visit in res)
            {
                var visitEntity = visits.FirstOrDefault(v => v.VisitId == visit.VisitId);
                if (visitEntity != null && visitEntity.VisitDetail != null)
                {
                    visit.VisitorSessionCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession != null)
                        .Sum(detail => detail.VisitorSession.Count);
                }
            }


            return res;
        }
        public async Task<Result<List<GetVisitNoDetailRes>>> GetAllVisitGraphQl(int pageSize, int pageNumber, string token)
        {
            var userAuthor = _jwt.DecodeAuthorJwt(token);
            var visit = new List<Visit>();

            if (userAuthor.Role == UserRoleEnum.Admin.ToString() || userAuthor.Role == UserRoleEnum.Manager.ToString())
            {
                visit = (await _visitRepo.FindAsync(s => true,
                    pageSize, pageNumber, s => s.OrderBy(x => x.CreateTime),
                    includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule.ScheduleType")).ToList();
            }
            if (userAuthor.Role == UserRoleEnum.DepartmentManager.ToString())
            {
                visit = (await _visitRepo.FindAsync(s => s.CreateBy.DepartmentId == userAuthor.DepartmentId,
                     pageSize, pageNumber, s => s.OrderBy(x => x.CreateTime),
                     includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule.ScheduleType")).ToList();
            }
            if (userAuthor.Role == UserRoleEnum.Staff.ToString())
            {
                visit = (await _visitRepo.FindAsync(s => s.ResponsiblePersonId == userAuthor.UserId,
                    pageSize, pageNumber, s => s.OrderBy(x => x.CreateTime),
                    includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule.ScheduleType")).ToList();
            }
            if (userAuthor.Role == UserRoleEnum.Security.ToString())
            {
                return Result.Failure<List<GetVisitNoDetailRes>>(Error.Unauthorized);

            }
            if (visit.Count() == 0)
            {
                return Result.Failure<List<GetVisitNoDetailRes>>(Error.NotFoundVisit);
            }
            var res = _mapper.Map<List<GetVisitNoDetailRes>>(visit);
            return res;
        }
        public async Task<Result<GetVisitRes>> GetVisitByScheduleUserId(int scheduleUserId)
        {
            var visit = (await _visitRepo.FindAsync(
                s => s.ScheduleUserId == scheduleUserId, 1, 1, includeProperties: "VisitDetail.Visitor,CreateBy"
                )).FirstOrDefault();

            if (visit == null)
            {
                return Result.Failure<GetVisitRes>(Error.NotFoundVisit);
            }
            var visitRes = _mapper.Map<GetVisitRes>(visit);
            return Result.Success(visitRes);
        }
        public async Task<Result<GetVisitRes>> GetVisitDetailByVisitId(int visitId)
        {
            var visits = (await _visitRepo.FindAsync(
                s => s.VisitId == visitId, 1, 1, includeProperties: "VisitDetail.VisitorSession,VisitDetail.Visitor,CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule.ScheduleType"
                )).FirstOrDefault();

            if (visits == null)
            {
                return Result.Failure<GetVisitRes>(Error.NotFound);
            }
            var visitRes = _mapper.Map<GetVisitRes>(visits);
            if (visits != null && visits.VisitDetail != null)
            {
                visitRes.VisitorSessionCount = visits.VisitDetail
                    .Where(detail => detail.VisitorSession != null)
                    .Sum(detail => detail.VisitorSession.Count);
            }
            return visitRes;
        }
        public Task<Result<GetVisitRes>> GetVisitByVisiDetailtId(int visitDetailId)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<List<GetVisitNoDetailRes>>> GetAllVisit()
        {
            var visit = await _visitRepo.GetAllAsync();
            var res = _mapper.Map<List<GetVisitNoDetailRes>>(visit);
            return res;
        }

        public async Task<Result<List<GetVisitByDateRes>>> GetVisitByDate(int pageSize, int pageNumber, DateTime date)
        {
            var visits = await _visitRepo.FindAsync(
                    s => s.ExpectedStartTime.Date <= date.Date
                    && s.ExpectedEndTime.Date >= date.Date
                    && (s.VisitStatus.Equals(VisitStatusEnum.Active.ToString()) || s.VisitStatus.Equals(VisitStatusEnum.ActiveTemporary.ToString())),
                    pageSize, pageNumber, includeProperties: "ScheduleUser.Schedule.ScheduleType,CreateBy,VisitDetail.VisitorSession"
                );

            if (visits.Count() == 0)
            {
                return Result.Failure<List<GetVisitByDateRes>>(Error.NotFoundVisitCurrentDate);
            }

            var visitResult = new List<Visit>();
            foreach (var item in visits)
            {
                if (IsValidVisit(item, date))
                {
                    visitResult.Add(item);
                }
            }

            if (!visitResult.Any())
            {
                return Result.Failure<List<GetVisitByDateRes>>(Error.NotFoundVisit);
            }

            var result = _mapper.Map<List<GetVisitByDateRes>>(visitResult);
            foreach (var visit in result)
            {
                var visitEntity = visitResult.FirstOrDefault(v => v.VisitId == visit.VisitId);
                if (visitEntity != null && visitEntity.VisitDetail != null)
                {
                    visit.VisitorSessionCheckedOutCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count != 0 && detail.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                        .Sum(detail => detail.VisitorSession.Count(session => session.Status == SessionStatus.CheckOut.ToString()));
                    visit.VisitorSessionCheckedInCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count != 0 && detail.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                        .Sum(detail => detail.VisitorSession.Count(session => session.Status == SessionStatus.CheckIn.ToString()));
                    visit.VisitorCheckOutedCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count != 0 && detail.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                        .Count();

                    visit.VisitDetailStartTime = visitEntity.VisitDetail
                        .Min(detail => (TimeSpan?)detail.ExpectedStartHour);

                    visit.VisitDetailEndTime = visitEntity.VisitDetail
                        .Max(detail => (TimeSpan?)detail.ExpectedEndHour);

                    visit.VisitorNoSessionCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count == 0)
                        .Count();
                    visit.VisitorCheckkInCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count != 0 && detail.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                        .Sum(detail => detail.VisitorSession.Count(session => session.Status == SessionStatus.CheckIn.ToString()));
                    visit.VisitorCheckkOutCount += visitEntity.VisitDetail
                        .SelectMany(detail => detail.VisitorSession)
                        .Where(session => session.Status == SessionStatus.CheckOut.ToString())
                        .OrderByDescending(session => session.CheckoutTime)
                        .FirstOrDefault() != null ? 1 : 0;
                }
            }
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
                        orderBy: s => s.OrderBy(s => s.VisitDetailId),
                        includeProperties: "Visitor,VisitorSession"
                    );
            }
            else
            {
                visitDetail = await _visitDetailRepo.FindAsync(
                        s => s.VisitId == visitId,
                        pageSize, pageNumber,
                        orderBy: s => s.OrderBy(s => s.VisitDetailId),
                        includeProperties: "Visitor,VisitorSession"
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
                    var images = new List<VisitorImage>();
                    foreach (var image in item.Visitor.VisitorImage)
                    {
                        images.Add(image.DecryptResponseImage(await CommonService.Decrypt(image.ImageURL)).Value);
                    }
                    item.Visitor.DecrypCredentialCard(images);
                }
                catch (Exception ex)
                {
                    return Result.Failure<List<GetVisitDetailRes>>(Error.DecryptError);
                }
            }

            var visitRes = _mapper.Map<List<GetVisitDetailRes>>(visitDetail);
            foreach (var item in visitDetail)
            {
                var correspondingVisitRes = visitRes.FirstOrDefault(v => v.VisitDetailId == item.VisitDetailId);

                if (item.VisitorSession.Count() == 0)
                {
                    if (correspondingVisitRes != null)
                    {
                        correspondingVisitRes.SessionStatus = "NoSession";
                    }
                }
                else if(item.VisitorSession.Count() != 0 && item.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                {
                    if (correspondingVisitRes != null)
                    {
                        correspondingVisitRes.SessionStatus = SessionStatus.CheckIn.ToString();
                    }
                }
                else
                {
                    if (correspondingVisitRes != null)
                    {
                        correspondingVisitRes.SessionStatus = SessionStatus.CheckOut.ToString();
                    }
                }
            }
            return visitRes;
        }

        public async Task<Result<List<GetVisitByCredentialCardRes>>> GetVisitByCurrentDateAndCredentialCard(string credentialCard, DateTime date)
        {
            var visitDetails = await _visitDetailRepo.FindAsync(
                s => s.Visitor.CredentialsCard.Equals(credentialCard)
                && s.Visit.ExpectedStartTime.Date <= DateTime.Now.Date
                && s.Visit.ExpectedEndTime.Date >= DateTime.Now.Date,
                int.MaxValue, 1, s => s.OrderByDescending(s => s.ExpectedStartHour), "Visit,Visit.ScheduleUser,Visit.ScheduleUser.Schedule,Visit.ScheduleUser.Schedule.ScheduleType,Visitor"
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
            int dateOfWeekInput = (int)date.DayOfWeek + 1;
            if (visit.ScheduleUser == null)
            {
                return true;
            }
            string[] daysOfSchedule = visit.ScheduleUser.Schedule.DaysOfSchedule.Split(',');
            if (visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessWeek.ToString())
                && daysOfSchedule.Contains(dateOfWeekInput.ToString()))
            {
                return true;
            }
            if (visit.ScheduleUser.Schedule.ScheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessMonth.ToString())
                && daysOfSchedule.Contains(date.Day.ToString()))
            {
                return true;
            }
            return false;
        }
        public async Task<Result<UpdateVisitBeforeStartDateCommand>> UpdateVisitBeforeStartDate(int visitId, UpdateVisitBeforeStartDateCommand command)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId, includeProperties: "VisitDetail, ScheduleUser")).FirstOrDefault();
            if (visit == null)
            {
                return Result.Failure<UpdateVisitBeforeStartDateCommand>(Error.NotFoundVisit);
            }
            var schedule = new Schedule();
            if (visit.ScheduleUser != null)
            {
                schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleId == visit.ScheduleUser.ScheduleId, includeProperties: "ScheduleType")).FirstOrDefault();
                visit.AddEndTime(command.ExpectedEndTime);
            }
            await _visitDetailRepo.RemoveRange(visit.VisitDetail);
            visit.RemoveDetail();
            foreach (var item in command.VisitDetail)
            {
                var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.VisitId != visitId &&
                    s.Visit.ExpectedEndTime >= command.ExpectedStartTime, int.MaxValue, 1, e => e.OrderBy(z => z.Visit.ExpectedStartTime), "Visit.ScheduleUser,Visit.ScheduleUser.Schedule,Visit.ScheduleUser.Schedule.ScheduleType");

                var addVisitDetailResult = await visit.AddVisitDetailOfOldVisitor(
                    visitorSchedule,
                    visit.ScheduleUser,
                    schedule,
                    item.ExpectedStartHour,
                    item.ExpectedEndHour,
                    true,
                    item.VisitorId);
                if (addVisitDetailResult.IsFailure)
                {
                    return Result.Failure<UpdateVisitBeforeStartDateCommand>(addVisitDetailResult.Error);
                }
            }

            visit = _mapper.Map(command, visit);
            visit.Update(command.UpdateById);
            await _visitRepo.UpdateAsync(visit);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<UpdateVisitBeforeStartDateCommand>(Error.CommitError);
            }

            return command;
        }
        //public async Task<Result<VisitCreateCommand>> UpdateVisit(int visitId, VisitCreateCommand command)
        //{
        //    var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId, includeProperties: "VisitDetail")).FirstOrDefault();
        //    if (visit == null)
        //    {
        //        return Result.Failure<VisitCreateCommand>(Error.NotFoundVisit);
        //    }

        //    var schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleId == command.ScheduleId, includeProperties: "ScheduleType")).FirstOrDefault();
        //    await _visitDetailRepo.RemoveRange(visit.VisitDetail);
        //    visit.AddEndTime(schedule.Duration);

        //    visit.RemoveDetail();
        //    foreach (var item in command.VisitDetail)
        //    {
        //        var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.VisitId != visitId &&
        //            s.Visit.ExpectedEndTime >= command.ExpectedStartTime, int.MaxValue, 1, e => e.OrderByDescending(z => z.Visit.ExpectedStartTime), "Visit,Visit.Schedule,Visit.Schedule.ScheduleType");

        //        var addVisitDetailResult = await visit.AddVisitDetailOfOldVisitor(
        //            visitorSchedule,
        //            schedule,
        //            item.ExpectedStartHour,
        //            item.ExpectedEndHour,
        //            true,
        //            item.VisitorId);
        //        if (addVisitDetailResult.IsFailure)
        //        {
        //            return Result.Failure<VisitCreateCommand>(addVisitDetailResult.Error);
        //        }
        //    }

        //    visit = _mapper.Map(command, visit);
        //    visit.Update(command.CreateById);
        //    await _visitRepo.UpdateAsync(visit);
        //    var commit = await _unitOfWork.CommitAsync();
        //    if (!commit)
        //    {
        //        return Result.Failure<VisitCreateCommand>(Error.CommitError);
        //    }

        //    return command;
        //}

        public Task<Result<bool>> DeleteVisit(int visitId)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByCreateById(int createById, int pageNumber, int pageSize)
        {
            var visit = (await _visitRepo.FindAsync(s => s.CreateById == createById, pageSize, pageNumber, s => s.OrderByDescending(x => x.CreateTime), includeProperties: "CreateBy,UpdateBy,ScheduleUser.Schedule.ScheduleType")).ToList();
            if (visit == null)
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.NotFoundVisit);
            }
            var visitRes = _mapper.Map<IEnumerable<GetVisitRes>>(visit);
            return visitRes.ToList();
        }
        public async Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByResponePersonId(int responPersonId, int pageNumber, int pageSize)
        {
            var visits = (await _visitRepo.FindAsync(s => s.ResponsiblePersonId == responPersonId, pageSize, pageNumber, s => s.OrderByDescending(x => x.CreateTime), includeProperties: "CreateBy,UpdateBy,ScheduleUser.Schedule.ScheduleType,VisitDetail.VisitorSession")).ToList();
            if (!visits.Any())
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.NotFoundVisit);
            }
            var visitRes = _mapper.Map<IEnumerable<GetVisitRes>>(visits);
            foreach (var visit in visitRes)
            {
                var visitEntity = visits.FirstOrDefault(v => v.VisitId == visit.VisitId);
                if (visitEntity != null && visitEntity.VisitDetail != null)
                {
                    visit.VisitorSessionCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession != null)
                        .Sum(detail => detail.VisitorSession.Count);
                }
            }
            return visitRes.ToList();
        }
        public async Task<Result<IEnumerable<GetVisitRes>>> GetVisitByDepartmentId(int departmentId, int pageNumber, int pageSize)
        {
            var visit = (await _visitRepo.FindAsync(s => s.ResponsiblePerson.DepartmentId == departmentId, pageSize, pageNumber, s => s.OrderByDescending(x => x.CreateTime), 
                includeProperties: "CreateBy,UpdateBy,ScheduleUser.Schedule.ScheduleType")).ToList();
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
                    includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule")).ToList();
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
                        includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule");
            }
            else if (user.Role.RoleName.Equals(UserRoleEnum.Staff.ToString()) ||
                    user.Role.RoleName.Equals(UserRoleEnum.Security.ToString()))
            {

                visit = (List<Visit>)await _visitRepo.FindAsync(
                        s => s.CreateById == userId,
                        pageSize,
                        pageNumber,
                        s => s.OrderByDescending(x => x.CreateTime),
                        includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule");
            }
            else
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.Unauthorized);
            }
            var visitRes = _mapper.Map<IEnumerable<GetVisitRes>>(visit);

            return Result.Success(visitRes);
        }

        public async Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByStatus(string token, string status, int pageNumber, int pageSize)
        {
            var userAuthen = _jwt.DecodeAuthorJwt(token);
            var visit = new List<Visit>();
            if (userAuthen.Role == UserRoleEnum.Staff.ToString())
            {
                visit = (await _visitRepo.FindAsync(s => (status != null ? s.VisitStatus.Equals(status) : true)
                && s.ResponsiblePersonId == userAuthen.UserId,
                pageSize, pageNumber, s => s.OrderByDescending(x => x.CreateTime),
                includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule")).ToList();

            }
            else if (userAuthen.Role == UserRoleEnum.Staff.ToString())
            {
                var userDepartment = (await _userRepo.FindAsync(
                        s => s.DepartmentId == userAuthen.DepartmentId
                    ));
                visit = (await _visitRepo.FindAsync(s => (status != null ? s.VisitStatus.Equals(status) : true)
              && userDepartment.Any(ud => ud.UserId == s.ResponsiblePersonId),
              pageSize, pageNumber, s => s.OrderByDescending(x => x.CreateTime),
              includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule")).ToList();
            }
            else if (userAuthen.Role == UserRoleEnum.Manager.ToString() || userAuthen.Role == UserRoleEnum.Admin.ToString())
            {
                visit = (await _visitRepo.FindAsync(s => (status != null ? s.VisitStatus.Equals(status) : true),
             pageSize, pageNumber, s => s.OrderByDescending(x => x.CreateTime),
             includeProperties: "CreateBy,UpdateBy,ScheduleUser,ScheduleUser.Schedule")).ToList();
            }
            else
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.Unauthorized);
            }
            if (visit == null)
            {
                return Result.Failure<IEnumerable<GetVisitRes>>(Error.NotFoundVisit);
            }
            var visitRes = _mapper.Map<IEnumerable<GetVisitRes>>(visit);
            return visitRes.ToList();
        }

        public async Task<Result<UpdateVisitAfterStartDateCommand>> UpdateVisitAfterStartDate(int visitId, UpdateVisitAfterStartDateCommand command)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId, includeProperties: "VisitDetail, ScheduleUser")).FirstOrDefault();
            if (visit == null)
            {
                return Result.Failure<UpdateVisitAfterStartDateCommand>(Error.NotFoundVisit);
            }
            if (visit.ExpectedStartTime > command.ExpectedEndTime)
            {
                return Result.Failure<UpdateVisitAfterStartDateCommand>(Error.UpdateTimeVisitError);
            }
            var schedule = new Schedule();
            if (visit.ScheduleUser != null)
            {
                schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleId == visit.ScheduleUser.ScheduleId, includeProperties: "ScheduleType")).FirstOrDefault();
            }

            visit.UpdateVisitAfterStartDate(command.VisitQuantity, command.ExpectedEndTime);
            foreach (var item in command.VisitDetail)
            {
                var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.VisitId != visitId &&
                    s.Visit.ExpectedEndTime >= visit.ExpectedStartTime, int.MaxValue, 1, e => e.OrderBy(z => z.Visit.ExpectedStartTime), "Visit.ScheduleUser,Visit.ScheduleUser.Schedule,Visit.ScheduleUser.Schedule.ScheduleType");

                var addVisitDetailResult = await visit.CheckUpdateVisit(
                    visitorSchedule,
                    visit.ScheduleUser,
                    schedule,
                    item.ExpectedStartHour,
                    item.ExpectedEndHour,
                    item.Status,
                    item.VisitorId);
                if (item.Status == false)
                {
                    continue;
                }
                if (addVisitDetailResult.IsFailure)
                {
                    return Result.Failure<UpdateVisitAfterStartDateCommand>(addVisitDetailResult.Error);
                }
                visit.UpdateAfterStartDate(addVisitDetailResult.Value.VisitDetail.ToList());             
            }


            visit.Update(command.UpdateById);
            await _visitRepo.UpdateAsync(visit);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<UpdateVisitAfterStartDateCommand>(Error.CommitError);
            }

            return command;
        }

        public async Task<Result<UpdateAppendTimeForVisitCommand>> AppendTime(int visitId, UpdateAppendTimeForVisitCommand command)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId, includeProperties: "VisitDetail")).FirstOrDefault();
            if (visit == null)
            {
                return Result.Failure<UpdateAppendTimeForVisitCommand>(Error.NotFoundVisit);
            }
            if (visit.ExpectedStartTime > command.ExpectedEndTime)
            {
                return Result.Failure<UpdateAppendTimeForVisitCommand>(Error.AppendTimeInvalid);
            }

            var schedule = (await _scheduleRepo.FindAsync(s => s.ScheduleId == visit.ScheduleUser.ScheduleId, includeProperties: "ScheduleType")).FirstOrDefault();

            visit.AddEndTime(command.ExpectedEndTime);

            foreach (var item in visit.VisitDetail)
            {
                var visitorSchedule = await _visitDetailRepo.FindAsync(s => s.VisitorId == item.VisitorId && s.VisitId != visitId &&
                    s.Visit.ExpectedEndTime >= visit.ExpectedStartTime, int.MaxValue, 1, e => e.OrderBy(z => z.Visit.ExpectedStartTime), "Visit.ScheduleUser,Visit.ScheduleUser.Schedule,Visit.ScheduleUser.Schedule.ScheduleType");

                var addVisitDetailResult = await visit.AddVisitDetailOfOldVisitor(
                    visitorSchedule,
                    visit.ScheduleUser,
                    schedule,
                    item.ExpectedStartHour,
                    item.ExpectedEndHour,
                    true,
                    item.VisitorId);
                if (addVisitDetailResult.IsFailure)
                {
                    if (addVisitDetailResult.Error == Error.DuplicateVisitorDetail)
                    {
                        continue;
                    }
                    return Result.Failure<UpdateAppendTimeForVisitCommand>(addVisitDetailResult.Error);
                }
            }

            visit = _mapper.Map(command, visit);

            visit.Update(command.UpdateById);

            await _visitRepo.UpdateAsync(visit);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<UpdateAppendTimeForVisitCommand>(Error.CommitError);
            }

            return command;
        }

        public async Task<Result<GetVisitNoDetailRes>> ReportVisit(int visitId)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId, includeProperties: "VisitDetail")).FirstOrDefault();
            if (visit == null)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.NotFoundVisit);
            }
            if (visit.VisitStatus != VisitStatusEnum.ActiveTemporary.ToString())
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.NotPermission);
            }
            visit.ReportVisit();
            await _visitRepo.UpdateAsync(visit);
            var commit = await (_unitOfWork.CommitAsync());
            if (!commit)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.CommitError);
            }
           
            var security = (await _userRepo.FindAsync(s => s.Role.RoleName == UserRoleEnum.Security.ToString()));
            var noti = Notification.Create("Thông báo cho tất cả bảo vê về chuyến thăm vi phạm",$"Chuyến thăm bị vi phạm, tên chuyến thăm: {visit.VisitName} - ngày: {visit.ExpectedStartTime}", visit.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
            foreach(var secu in security)
            {
                noti.Value.AddUserNoti((int)visit.ResponsiblePersonId, secu.UserId);
            }
            await _notificationRepo.AddAsync(noti.Value);
            var commit2 = await _unitOfWork.CommitAsync();
            if (!commit2)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.CommitError);
            }
            foreach (var secu in security)
            {
                await _notifications.SendMessageAssignForStaff("Thông báo cho tất cả bảo vê về chuyến thăm vi phạm", $"Chuyến thăm bị vi phạm, tên chuyến thăm: {visit.VisitName} - ngày: {visit.ExpectedStartTime}", secu.UserId, 1);
            }
            return _mapper.Map<GetVisitNoDetailRes>(visit);
        }

        public async Task<Result<GetVisitNoDetailRes>> CancelVisit(int visitId)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId)).FirstOrDefault();
            if (visit == null)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.NotFoundVisit);
            }
            if (visit.VisitStatus != VisitStatusEnum.Pending.ToString() && visit.VisitStatus != VisitStatusEnum.Active.ToString())
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.NotPermission);
            }
            visit.CancelVisit();
            await _visitRepo.UpdateAsync(visit);
            var commit = await (_unitOfWork.CommitAsync());
            if (!commit)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.CommitError);
            }
            return _mapper.Map<GetVisitNoDetailRes>(visit);
        }

        public async Task<Result<GetVisitNoDetailRes>> ActiveVisit(int visitId)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId)).FirstOrDefault();
            if (visit == null)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.NotFoundVisit);
            }
            if (visit.VisitStatus != VisitStatusEnum.ActiveTemporary.ToString())
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.NotPermission);
            }
            visit.ActiveVisit();
            await _visitRepo.UpdateAsync(visit);
            var commit = await (_unitOfWork.CommitAsync());
            if (!commit)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.CommitError);
            }
            try
            {
                var noti = Notification.Create($"Chuyến thăm {visit.VisitName} đã được chấp thuận", "", visit.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
                var departmentMananger = (await _userRepo.FindAsync(s => s.DepartmentId == visit.ResponsiblePerson.DepartmentId && s.Role.RoleName == UserRoleEnum.DepartmentManager.ToString())).FirstOrDefault();
                noti.Value.AddUserNoti(departmentMananger.UserId, (int)visit.ResponsiblePersonId);
                await _notificationRepo.AddAsync(noti.Value);
                var commit2 = await _unitOfWork.CommitAsync();
                if (!commit2)
                {
                    return Result.Failure<GetVisitNoDetailRes>(Error.CommitError);
                }
                await _notifications.SendMessageAssignForStaff($"Chuyến thăm {visit.VisitName} đã được chấp thuận", "", (int)visit.ResponsiblePersonId, 1);
            }
            catch
            {

            }
           
            return _mapper.Map<GetVisitNoDetailRes>(visit);
        }

        public async Task<Result<List<GetVisitByDateRes>>> GetVisitByDateByVisitID(int pageSize, int pageNumber, int visitId)
        {
            var visits = await _visitRepo.FindAsync(
                    s => s.VisitId == visitId
                    && (s.VisitStatus.Equals(VisitStatusEnum.Active.ToString()) || s.VisitStatus.Equals(VisitStatusEnum.ActiveTemporary.ToString())),
                    pageSize, pageNumber, includeProperties: "ScheduleUser.Schedule.ScheduleType,CreateBy,VisitDetail.VisitorSession"
                );
            if (visits.Count() == 0)
            {
                return Result.Failure<List<GetVisitByDateRes>>(Error.NotFoundVisitCurrentDate);
            }

            var visitResult = new List<Visit>();
            foreach (var item in visits)
            {
                    visitResult.Add(item);
            }

            if (!visitResult.Any())
            {
                return Result.Failure<List<GetVisitByDateRes>>(Error.NotFoundVisit);
            }
            var result = _mapper.Map<List<GetVisitByDateRes>>(visitResult);
            foreach (var visit in result)
            {
                var visitEntity = visitResult.FirstOrDefault(v => v.VisitId == visit.VisitId);
                if (visitEntity != null && visitEntity.VisitDetail != null)
                {
                    visit.VisitorSessionCheckedOutCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count != 0 && detail.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                        .Sum(detail => detail.VisitorSession.Count(session => session.Status == SessionStatus.CheckOut.ToString()));
                    visit.VisitorSessionCheckedInCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count != 0 && detail.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                        .Sum(detail => detail.VisitorSession.Count(session => session.Status == SessionStatus.CheckIn.ToString()));
                    visit.VisitorCheckOutedCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count != 0 && detail.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                        .Count();
                    visit.VisitDetailStartTime = visitEntity.VisitDetail
                        .Min(detail => (TimeSpan?)detail.ExpectedStartHour);

                    visit.VisitDetailEndTime = visitEntity.VisitDetail
                        .Max(detail => (TimeSpan?)detail.ExpectedEndHour);

                    visit.VisitorNoSessionCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count == 0)
                        .Count();
                    visit.VisitorCheckkInCount = visitEntity.VisitDetail
                        .Where(detail => detail.VisitorSession.Count != 0 && detail.VisitorSession.Any(session => session.CheckinTime.Date == DateTime.Now.Date))
                        .Sum(detail => detail.VisitorSession.Count(session => session.Status == SessionStatus.CheckIn.ToString()));
                    visit.VisitorCheckkOutCount += visitEntity.VisitDetail
                        .SelectMany(detail => detail.VisitorSession)
                        .Where(session => session.Status == SessionStatus.CheckOut.ToString())
                        .OrderByDescending(session => session.CheckoutTime)
                        .FirstOrDefault() != null ? 1 : 0;
                }
            }
            return result;
        }

        public async Task<Result<GetVisitNoDetailRes>> ViolationResolvedVisit(int visitId)
        {
            var visit = (await _visitRepo.FindAsync(s => s.VisitId == visitId)).FirstOrDefault();
            if (visit == null)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.NotFoundVisit);
            }
            if (visit.VisitStatus != VisitStatusEnum.Violation.ToString())
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.NotPermission);
            }
            visit.ViolationResolvedVisit();
            await _visitRepo.UpdateAsync(visit);
            var commit = await(_unitOfWork.CommitAsync());
            if (!commit)
            {
                return Result.Failure<GetVisitNoDetailRes>(Error.CommitError);
            }
            //try
            //{
            //    var noti = Notification.Create($"Chuyến thăm {visit.VisitName} đã được chấp thuận", "", visit.VisitId.ToString(), DateTime.Now, null, (int)NotificationTypeEnum.Visit);
            //    var departmentMananger = (await _userRepo.FindAsync(s => s.DepartmentId == visit.ResponsiblePerson.DepartmentId && s.Role.RoleName == UserRoleEnum.DepartmentManager.ToString())).FirstOrDefault();
            //    noti.Value.AddUserNoti(departmentMananger.UserId, (int)visit.ResponsiblePersonId);
            //    await _notificationRepo.AddAsync(noti.Value);
            //    var commit2 = await _unitOfWork.CommitAsync();
            //    if (!commit2)
            //    {
            //        return Result.Failure<GetVisitNoDetailRes>(Error.CommitError);
            //    }
            //    await _notifications.SendMessageAssignForStaff($"Chuyến thăm {visit.VisitName} đã được chấp thuận", "", (int)visit.ResponsiblePersonId, 1);
            //}
            //catch
            //{

            //}

            return _mapper.Map<GetVisitNoDetailRes>(visit);
        }
    }
}
