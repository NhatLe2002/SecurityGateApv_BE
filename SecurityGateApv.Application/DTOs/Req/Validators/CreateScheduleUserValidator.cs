using FluentValidation;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.Validators
{
    public class CreateScheduleUserValidator : AbstractValidator<CreateScheduleUserCommand>
    {
        public CreateScheduleUserValidator(IUserRepo userRepo, IScheduleRepo scheduleRepo)
        {
            RuleFor(s => s.Title).NotNull().NotEmpty();
            RuleFor(s => s.Description).NotNull().NotEmpty();
            RuleFor(s => s.AssignToId).NotNull().NotEmpty().Must(s =>
            {
                if (userRepo.IsAny(t => t.UserId == s).GetAwaiter().GetResult())
                {
                    return true;

                }
                return false;
            }).WithMessage("User Id not exist");
            RuleFor(s => s.ScheduleId).NotNull().NotEmpty().Must(s =>
            {
                if (scheduleRepo.IsAny(t => t.ScheduleId == s).GetAwaiter().GetResult())
                {
                    return true;

                }
                return false;
            }).WithMessage("Schedule Id not exist");
            RuleFor(s => s.DeadlineTime).NotNull().NotEmpty().Must(s =>
            {
                if(s > DateTime.Now)
                {
                    return true;
                }
                return false;                   
            }).WithMessage("Thời cho nhiệm vụ hạn phải lớn hơn 1 ngày");
            RuleFor(s => s.StartDate).NotNull().NotEmpty().Must(s =>
            {
                if (s > DateTime.Now)
                {
                    return true;
                }
                return false;
            }).WithMessage("Ngày bắt đầu không hợp lệ");
            RuleFor(s => s.EndDate).NotNull().NotEmpty().Must(s =>
            {
                if (s > DateTime.Now)
                {
                    return true;
                }
                return false;
            }).WithMessage("Ngày kết thúc không hợp lệ");
            RuleFor(s => new { s.StartDate, s.EndDate}).NotNull().NotEmpty().Must(s =>
            {
                if (s.StartDate < s.EndDate)
                {
                    return true;
                }
                return false;
            }).WithMessage("Ngày bắt đầu phải trước ngày kết thúc");
        }
    }
}
