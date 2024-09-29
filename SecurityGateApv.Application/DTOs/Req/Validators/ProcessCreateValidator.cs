using FluentValidation;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.Validators
{
    public class ProcessCreateValidator : AbstractValidator<ProcessCreateAndDetailCommand>
    {
        private readonly IVisitTypeRepo _visitTypeRepo;
        private readonly IUserRepo _userRepo1;

        public ProcessCreateValidator(IVisitTypeRepo visitTypeRepo, IUserRepo userRepo)
        {
            _visitTypeRepo = visitTypeRepo;
            _userRepo1 = userRepo;
            RuleFor(s => s.ProcessName)
                 .NotEmpty()
                 .WithMessage("Process name is required.");
            //RuleFor(s => s.Status).NotEmpty().NotNull();
            RuleFor(s => s.Description)
                 .NotEmpty()
                 .WithMessage("Description is required.");
            RuleFor(s => s.VisitTypeId).NotEmpty().NotNull().Must(s =>
            {
                return visitTypeRepo.IsAny(x => x.VisitTypeId == s).GetAwaiter().GetResult();
            }).WithMessage("Visit type Id not exist");
            RuleFor(s => s.CreateBy).NotEmpty().NotNull().Must(s =>
            {
                return userRepo.IsAny(x => x.UserId == s).GetAwaiter().GetResult();
            });
            RuleFor(s => s)
            .Must( (command) =>
                 ValidateDaysOfProcess(command.VisitProject,command.VisitTypeId).Result)
            .WithMessage("DaysOfProcess is not valid for the selected Visit Type.");
        }
        private async Task<bool> ValidateDaysOfProcess(ICollection<VisitProcessCommand> command, int visitTypeId)
        {
            var visitType = await _visitTypeRepo.GetByIdAsync(visitTypeId);
            if (visitType == null)
                return false;
            var tesdt= Enum.GetValues(typeof(VisitTypeEnum))
                .Cast<VisitTypeEnum>()
                .Select(v => v.ToString())
                .ToList();
            if (visitType.VisitTypeName.Equals(VisitTypeEnum.ProcessWeek.ToString()))
            {
                foreach (var item in command)
                {
                    return IsValidDaysOfProcess(item.DaysOfProcess, 1, 7);
                    
                }
            }

            if(visitType.VisitTypeName.Equals(VisitTypeEnum.Project.ToString())) {
                foreach (var item in command)
                {
                    return AreValidDaysForProject(item.DaysOfProcess, item.ExpectedStartDate.Month);

                }
            }

            return true;
        }
        private bool IsValidDaysOfProcess(string daysOfProcess, int min, int max)
        {
            var days = daysOfProcess.Split(',').Select(d => d.Trim());
            return days.All(day => int.TryParse(day, out int result) && result >= min && result <= max);
        }

        private bool AreValidDaysForProject(string daysOfProcess, int month)
        {
            var daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month);
            var days = daysOfProcess.Split(',').Select(d => d.Trim());

            return days.All(day =>
            {
                if (int.TryParse(day, out int result))
                {
                    return result > 0 && result <= daysInMonth;
                }
                return false;
            });
        }
    }
    public class VisitProcessCreateValidator : AbstractValidator<VisitProcessCommand>
    {
        private readonly IVisitTypeRepo _visitTypeRepo;
        public VisitProcessCreateValidator(IVisitTypeRepo visitTypeRepo, IUserRepo userRepo)
        {
            _visitTypeRepo = visitTypeRepo;
            RuleFor(s => s.ExpectedStartTime)
             .NotEmpty()
             .NotNull()
             .Must(time => time.Hours >= 0 && time.Hours < 24)
             .WithMessage("Start time must be greater than or equal to 0 and less than 24 hours.");

            RuleFor(s => s.ExpectedEndTime)
           .NotEmpty()
           .NotNull()
           .Must((command, endTime) => endTime < command.ExpectedStartTime)
           .WithMessage("End time must be less than start time.");

            RuleFor(s => s.ExpectedStartDate)
            .NotEmpty()
            .NotNull()
            .GreaterThan(DateTime.Now)
            .WithMessage("Start date must be greater than today.");
            RuleFor(s => s.ExpectedEndDate)
            .NotEmpty()
            .NotNull()
            .GreaterThan(s => s.ExpectedStartDate)
            .WithMessage("End date must be after start date.");
            RuleFor(s => s.VisitQuantity)
            .NotEmpty()
            .NotNull()
            .Must(s => s > 0)
            .WithMessage("Visit quantity must be greater than 0.");

            
        }
       

    }

    public class ProcesCreateValidator : AbstractValidator<ProcessCreateCommand>
    {
        private readonly IVisitTypeRepo _visitTypeRepo;
        private readonly IUserRepo _userRepo1;

        public ProcesCreateValidator(IVisitTypeRepo visitTypeRepo, IUserRepo userRepo)
        {
            _visitTypeRepo = visitTypeRepo;
            _userRepo1 = userRepo;
            RuleFor(s => s.ProcessName)
                 .NotEmpty()
                 .WithMessage("Process name is required.");
            //RuleFor(s => s.Status).NotEmpty().NotNull();
            RuleFor(s => s.Description)
                 .NotEmpty()
                 .WithMessage("Description is required.");
            RuleFor(s => s.VisitTypeId).NotEmpty().NotNull().Must(s =>
            {
                return visitTypeRepo.IsAny(x => x.VisitTypeId == s).GetAwaiter().GetResult();
            }).WithMessage("Visit type Id not exist");
            RuleFor(s => s.CreateBy).NotEmpty().NotNull().Must(s =>
            {
                return userRepo.IsAny(x => x.UserId == s).GetAwaiter().GetResult();
            });
           
        }
    }
}
