using FluentValidation;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.Validators
{
    public class VisitCreateCommandValidator : AbstractValidator<VisitCreateCommand>
    {
        public VisitCreateCommandValidator(IUserRepo userRepo, IVisitorRepo visitorRepo, IScheduleRepo scheduleRepo)
        {
            RuleFor(s => s.VisitName).NotNull().NotEmpty();
            RuleFor(s => s.ExpectedEndTime).NotNull().NotEmpty();
            RuleFor(s => s.ExpectedStartTime).NotNull().NotEmpty();
            RuleFor(s => s.Description).NotNull().NotEmpty();
            RuleFor(s => s.VisitQuantity).NotNull().NotEmpty().Must(s =>s>0).WithMessage("Must greater than zero");
            RuleFor(s => new {s.VisitQuantity, s.VisitDetail}).NotNull().NotEmpty().Must(s =>
            {
                if(s.VisitQuantity == s.VisitDetail.Count)
                {
                    return true;
                }
                return false;
            }).WithMessage("Quantity not match visit detail");
            RuleFor(s => s.CreateById).NotNull().NotEmpty().Must(s =>
            {
                return userRepo.IsAny(t=> t.UserId == s).GetAwaiter().GetResult();
            }).WithMessage("User Id is not exist");
            RuleFor(s => s.ResponsiblePersonId).NotNull().NotEmpty().Must(s =>
            {
                return userRepo.IsAny(t=> t.UserId == s).GetAwaiter().GetResult();
            }).WithMessage("ResponsiblePerson Id is not exist");
            RuleFor(s => s.ScheduleId).NotNull().NotEmpty().Must(s =>
            {
                return scheduleRepo.IsAny(t => t.ScheduleId == s).GetAwaiter().GetResult();
            }).WithMessage("Schedule Id is not exist");
            RuleForEach(s => s.VisitDetail).NotNull().NotEmpty().Must(x =>
            {
                if (x.ExpectedEndHour < x.ExpectedStartHour)
                {
                    return false;
                }
                if(!visitorRepo.IsAny(s=>s.VisitorId == x.VisitorId).GetAwaiter().GetResult())
                {
                    return false;
                }
                return true;
            }
            ).WithMessage("Time, visitor id not valid");
        }

            
    }
    public class VisitCreateCommandDailyValidator : AbstractValidator<VisitCreateCommandDaily>
    {
        public VisitCreateCommandDailyValidator(IUserRepo userRepo, IVisitorRepo visitorRepo)
        {
            RuleFor(s => s.VisitName).NotNull().NotEmpty();
            RuleFor(s => s.ExpectedEndTime).NotNull().NotEmpty();
            RuleFor(s => s.ExpectedStartTime).NotNull().NotEmpty();
            RuleFor(s => s.Description).NotNull().NotEmpty();
            RuleFor(s => s.VisitQuantity).NotNull().NotEmpty().Must(s => s > 0).WithMessage("Must greater than zero");
            RuleFor(s => new { s.VisitQuantity, s.VisitDetail }).NotNull().NotEmpty().Must(s =>
            {
                if (s.VisitQuantity == s.VisitDetail.Count)
                {
                    return true;
                }
                return false;
            }).WithMessage("Quantity not match visit detail");
            RuleFor(s => s.CreateById).NotNull().NotEmpty().Must(s =>
            {
                return userRepo.IsAny(t => t.UserId == s).GetAwaiter().GetResult();
            }).WithMessage("User Id is not exist");
            RuleForEach(s => s.VisitDetail).NotNull().NotEmpty().Must(x =>
            {
                if (x.ExpectedEndHour < x.ExpectedStartHour)
                {
                    return false;
                }
                if (!visitorRepo.IsAny(s => s.VisitorId == x.VisitorId).GetAwaiter().GetResult())
                {
                    return false;
                }
                return true;
            }
            ).WithMessage("Time, visitor id not valid");
        }


    }
}
