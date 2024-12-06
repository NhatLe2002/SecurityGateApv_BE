using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IVisitRepo _visitRepo;
        private readonly IUserRepo _userRepo;
        private readonly IVisitorRepo _visitorRepo;
        private readonly IScheduleRepo _scheduleRepo;
        private readonly IScheduleUserRepo _scheduleUserRepo;

        public DashboardService(IVisitRepo visitRepo, IUserRepo userRepo, IVisitorRepo visitorRepo, IScheduleRepo scheduleRepo, IScheduleUserRepo scheduleUserRepo)
        {
            _visitRepo = visitRepo;
            _userRepo = userRepo;
            _visitorRepo = visitorRepo;
            _scheduleRepo = scheduleRepo;
            _scheduleUserRepo = scheduleUserRepo;
        }

        public async Task<Result<DashboardMission>> GetMission(int? staffId)
        {
            var res = new DashboardMission()
            {
                Total = 0,
                WaitForFinishTask = 0
            };
            var schedules = (await _scheduleUserRepo.GetAllAsync());
            if (staffId != null)
            {
                var staff = (await _userRepo.IsAny(s => s.UserId == staffId && s.RoleId == (int)UserRoleEnum.Staff));
                if (!staff)
                {
                    return Result.Failure<DashboardMission>(Error.NotFound);
                }
                res.Total = schedules.Count(s => s.AssignToId == staffId);
                res.WaitForFinishTask = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Assigned.ToString() && s.AssignToId == staffId);
            }
            else
            {
                res.Total = schedules.Count();
                res.WaitForFinishTask = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Assigned.ToString());
            }
            

            return res;
        }

        public async Task<Result<DashboardSchedule>> GetSchedule()
        {
            var res = new DashboardSchedule()
            {
                Month = 0,
                Week = 0
            };
            var schedules = (await _scheduleRepo.GetAllAsync());
            res.Month = schedules.Count(s => s.ScheduleTypeId == (int)ScheduleTypeEnum.ProcessMonth);
            res.Week = schedules.Count(s => s.ScheduleTypeId == (int)ScheduleTypeEnum.ProcessWeek);

            return res;
        }

        public async Task<Result<DashboardUserRes>> GetUser()
        {
            var res = new DashboardUserRes()
            {
                Admin = 0,
                DepartmentManager = 0,
                Manager = 0,
                Security = 0,
                Staff = 0,
            };
            var user = (await _userRepo.GetAllAsync());
            res.Admin = user.Count(s => s.RoleId == (int)UserRoleEnum.Admin);
            res.Manager = user.Count(s => s.RoleId == (int)UserRoleEnum.Manager);
            res.DepartmentManager = user.Count(s => s.RoleId == (int)UserRoleEnum.DepartmentManager);
            res.Security = user.Count(s => s.RoleId == (int)UserRoleEnum.Security);
            res.Staff = user.Count(s => s.RoleId == (int)UserRoleEnum.Staff);
            return res;
        }

        public async Task<Result<DashBoardVisitRes>> GetVisit()
        {
            var res = new DashBoardVisitRes()
            {
                Total = 0,
                Daily = 0,
                Month = 0,
                Week = 0,
                Cancel = 0,
                Violation = 0,
            };
            var visit = (await _visitRepo.GetAllAsync());
            res.Total = visit.Count();
            res.Daily = (await _visitRepo.FindAsync(s => s.ScheduleUser != null && s.ScheduleUser.Schedule.ScheduleTypeId == (int)ScheduleTypeEnum.VisitDaily, int.MaxValue)).Count();
            res.Week = (await _visitRepo.FindAsync(s => s.ScheduleUser != null && s.ScheduleUser.Schedule.ScheduleTypeId == (int)ScheduleTypeEnum.ProcessWeek, int.MaxValue)).Count();
            res.Month = (await _visitRepo.FindAsync(s => s.ScheduleUser != null && s.ScheduleUser.Schedule.ScheduleTypeId == (int)ScheduleTypeEnum.ProcessMonth, int.MaxValue)).Count();
            res.Cancel = visit.Count(s => s.VisitStatus == VisitStatusEnum.Cancelled.ToString());
            res.Violation = visit.Count(s => s.VisitStatus == VisitStatusEnum.Violation.ToString());

            return res;
        }

        public async Task<Result<DashboardVisitorRes>> GetVisitor()
        {
            var res = new DashboardVisitorRes()
            {
                Active = 0,
                Total = 0,
                Inavtive = 0,
            };
            var visitor = (await _visitorRepo.GetAllAsync());
            res.Total = visitor.Count();
            res.Active = visitor.Count(s => s.Status == VisitorStatusEnum.Active.ToString());
            res.Inavtive = visitor.Count(s => s.Status == VisitorStatusEnum.InActive.ToString());
            return res;
        }
    }
}
