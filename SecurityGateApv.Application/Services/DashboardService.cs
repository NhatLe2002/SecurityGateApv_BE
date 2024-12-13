using AutoMapper;
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

namespace SecurityGateApv.Application.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IVisitRepo _visitRepo;
        private readonly IUserRepo _userRepo;
        private readonly IVisitorRepo _visitorRepo;
        private readonly IScheduleRepo _scheduleRepo;
        private readonly IScheduleUserRepo _scheduleUserRepo;
        private readonly IVisitorSessionRepo _visitorSessionRepo;
        private readonly ICardRepo _cardRepo;
        private readonly IMapper _mapper;

        public DashboardService(IVisitRepo visitRepo, IUserRepo userRepo, IVisitorRepo visitorRepo, IScheduleRepo scheduleRepo, IScheduleUserRepo scheduleUserRepo, IVisitorSessionRepo visitorSessionRepo, IMapper mapper, ICardRepo cardRepo)
        {
            _visitRepo = visitRepo;
            _userRepo = userRepo;
            _visitorRepo = visitorRepo;
            _scheduleRepo = scheduleRepo;
            _scheduleUserRepo = scheduleUserRepo;
            _visitorSessionRepo = visitorSessionRepo;
            _mapper = mapper;
            _cardRepo = cardRepo;
        }

        public DashboardService()
        {
        }

        public async Task<Result<DashboardMission>> GetMission(int? staffId)
        {
            var res = new DashboardMission()
            {
                Total = 0,
                Approved = 0,
                Pending = 0,
                Assigned = 0,
                Expired = 0,
                Rejected = 0    
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
                res.Assigned = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Assigned.ToString() && s.AssignToId == staffId);
                res.Pending = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Pending.ToString() && s.AssignToId == staffId);
                res.Approved = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Approved.ToString() && s.AssignToId == staffId);
                res.Expired = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Expired.ToString() && s.AssignToId == staffId);
                res.Rejected = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Rejected.ToString() && s.AssignToId == staffId);
            }
            else
            {
                res.Total = schedules.Count();
                res.Assigned = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Assigned.ToString());
                res.Pending = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Pending.ToString());
                res.Approved = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Approved.ToString());
                res.Expired = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Expired.ToString());
                res.Rejected = schedules.Count(s => s.Status == ScheduleUserStatusEnum.Rejected.ToString());
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
                Active = 0,
                ActiveTemporary = 0,
                Pending = 0,
                Inactive = 0,
            };
            var visit = (await _visitRepo.GetAllAsync());
            res.Total = visit.Count();
            res.Daily = (await _visitRepo.FindAsync(s => s.ScheduleUser == null, int.MaxValue)).Count();
            res.Week = (await _visitRepo.FindAsync(s => s.ScheduleUser != null && s.ScheduleUser.Schedule.ScheduleTypeId == (int)ScheduleTypeEnum.ProcessWeek, int.MaxValue)).Count();
            res.Month = (await _visitRepo.FindAsync(s => s.ScheduleUser != null && s.ScheduleUser.Schedule.ScheduleTypeId == (int)ScheduleTypeEnum.ProcessMonth, int.MaxValue)).Count();
            res.Cancel = visit.Count(s => s.VisitStatus == VisitStatusEnum.Cancelled.ToString());
            res.Violation = visit.Count(s => s.VisitStatus == VisitStatusEnum.Violation.ToString());
            res.Active = visit.Count(s => s.VisitStatus == VisitStatusEnum.Active.ToString());
            res.Inactive = visit.Count(s => s.VisitStatus == VisitStatusEnum.Inactive.ToString());
            res.Pending = visit.Count(s => s.VisitStatus == VisitStatusEnum.Pending.ToString());
            res.ActiveTemporary = visit.Count(s => s.VisitStatus == VisitStatusEnum.ActiveTemporary.ToString());

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

        public async Task<Result<VisitorSessionCountMonthRes>> GetVisitorSessionCountByMonth(int year, int month)
        {
            var res = new VisitorSessionCountMonthRes();
            var visitorSessions = await _visitorSessionRepo.GetAllAsync();

            res.DailyCounts = visitorSessions
                .Where(vs => vs.CheckinTime.Year == year && vs.CheckinTime.Month == month)
                .GroupBy(vs => vs.CheckinTime.Day)
                .Select(g => new DailyCount
                {
                    Day = g.Key,
                    Count = g.Count()
                })
                .OrderBy(dc => dc.Day)
                .ToList();

            return Result.Success(res);
        }

        public async Task<Result<VisitorSessionCountRes>> GetVisitorSessionCountByYear(int year)
        {
            var res = new VisitorSessionCountRes();
            var visitorSessions = await _visitorSessionRepo.GetAllAsync();

            res.MonthlyCounts = visitorSessions
                .Where(vs => vs.CheckinTime.Year == year)
                .GroupBy(vs => vs.CheckinTime.Month)
                .Select(g => new MonthlyCount
                {
                    Month = g.Key,
                    Count = g.Count()
                })
                .OrderBy(mc => mc.Month)
                .ToList();

            return Result.Success(res);
        }

        public async Task<Result<List<GetVisitorSessionRes>>> GetRecentVisitorSessions(int count = 5)
        {
            var visitSession = (await _visitorSessionRepo.FindAsync(
                 s => true /*s.VisitDetail.Visit.CreateBy.DepartmentId == userAuthor.DepartmentId
                && s.CheckinTime.Date == DateTime.Now.Date*/,
                 count, 1,
                 orderBy: s => s.OrderByDescending(s => s.CheckinTime),
                 includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,VisitorSessionsImages,VisitDetail.Visitor"
             )).ToList();
            var result = _mapper.Map<List<GetVisitorSessionRes>>(visitSession);
            return Result.Success(result);
        }
        public async Task<Result<List<VisitorSessionStatusCountRes>>> GetVisitorSessionCountByStatusForToday()
        {
            var today = DateTime.Today;
            var visitorSessions = await _visitorSessionRepo.FindAsync(
                vs => vs.CheckinTime.Date == today,
                int.MaxValue, 1,
                orderBy: vs => vs.OrderBy(v => v.Status),
                includeProperties: "SecurityIn,SecurityOut,GateIn,GateOut,VisitorSessionsImages"
            );

            var statusCounts = visitorSessions
                .GroupBy(vs => vs.Status)
                .Select(g => new VisitorSessionStatusCountRes
                {
                    Status = g.Key,
                    Count = g.Count()
                })
                .OrderBy(sc => sc.Status)
                .ToList();
            if(!statusCounts.Any(s => s.Status == SessionStatus.CheckOut.ToString()))
            {
                statusCounts.Add(new VisitorSessionStatusCountRes
                {
                    Status = SessionStatus.CheckOut.ToString(),
                    Count = 0
                });
            }
            if (!statusCounts.Any(s => s.Status == SessionStatus.CheckIn.ToString()))
            {
                statusCounts.Add(new VisitorSessionStatusCountRes
                {
                    Status = SessionStatus.CheckIn.ToString(),
                    Count = 0
                });
            }

            return Result.Success(statusCounts);
        }
        public async Task<Result<List<CardStatusCountRes>>> GetCardCountByStatus()
        {
            var cards = await _cardRepo.GetAllAsync();

            var statusCounts = cards
                .GroupBy(c => c.CardStatus)
                .Select(g => new CardStatusCountRes
                {
                    Status = g.Key.ToString(), 
                    Count = g.Count()
                })
                .OrderBy(sc => sc.Status)
                .ToList();

            return Result.Success(statusCounts);
        }

        public async Task<Result<GetCardCountIssueRes>> GetCardBountByIssue()
        {
            var cardAll = await _cardRepo.GetAllAsync();
            var cards = await _cardRepo.FindAsync(c => c.VisitCards.Any(s => s.VisitCardStatus == VisitCardStatusEnum.Issue.ToString()), int.MaxValue, 1);
            var res = new GetCardCountIssueRes()
            {

                TotalCard = cardAll.Count(),
                TotalCardIssue = cards.Count()
            };
            return Result.Success(res);
        }
    }
}
