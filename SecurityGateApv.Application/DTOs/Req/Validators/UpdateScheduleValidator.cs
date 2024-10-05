using FluentValidation;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.Validators
{
    public class UpdateScheduleValidator : AbstractValidator<UpdateScheduleCommand>
    {
        private readonly IScheduleTypeRepo _scheduleTypeRepo;
        private readonly IUserRepo _userRepo;
        public UpdateScheduleValidator(IScheduleTypeRepo scheduleTypeRepo, IUserRepo userRepo)
        {
            _scheduleTypeRepo = scheduleTypeRepo;
            _userRepo = userRepo;

            RuleFor(s => s.ScheduleName)
             .NotEmpty()
             .WithMessage("Schedule name is required.");

            RuleFor(s => s.DaysOfProcess)
                .NotEmpty()
                .WithMessage("Days of process is required.");

            RuleFor(s => s.Duration)
                .GreaterThan(0)
                .WithMessage("Duration must be greater than zero.");

            RuleFor(s => s.Description)
                .NotEmpty()
                .WithMessage("Description is required.");
            RuleFor(s => s.Status)
                .NotNull()
                .WithMessage("Status is required.");

           /* RuleFor(s => s.ScheduleTypeId)
                .NotEmpty()
                .WithMessage("Schedule type ID is required.")
                .Must((id, cancellation) => _scheduleTypeRepo.IsAny(x => x.ScheduleTypeId == id.ScheduleTypeId).GetAwaiter().GetResult()
                ).WithMessage("Schedule type ID does not exist.");

            RuleFor(s => s.CreateById)
                .NotEmpty()
                .WithMessage("Creator ID is required.")
                .Must((id, cancellation) =>
                {
                    return _userRepo.IsAny(x => x.UserId == id.CreateById).GetAwaiter().GetResult();
                }).WithMessage("Creator ID does not exist.");*/
            /*RuleFor(s => s)
               .Must((command) => ValidateDaysOfProcess(command).GetAwaiter().GetResult())
               .WithMessage("DaysOfProcess is not valid for the selected Visit Type.");*/
        }
        private async Task<bool> ValidateDaysOfProcess(UpdateScheduleCommand command)
        {
            var scheduleType = await _scheduleTypeRepo.GetByIdAsync(command.ScheduleTypeId);
            if (scheduleType == null) return false;


            if (scheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessWeek.ToString()))
            {

                return IsValidDaysOfProcess(command.DaysOfProcess, 1, 7);
            }

            if (scheduleType.ScheduleTypeName.Equals(ScheduleTypeEnum.ProcessMonth.ToString()))
            {
                return IsValidDaysOfProcess(command.DaysOfProcess, 1, 31);
            }
            var days = command.DaysOfProcess.Split(',')
                            .Select(d => d.Trim());
            if (days.Count() > command.Duration)
            {
                return false;
            }
            if (days.Any())
            {
                return days.All(day =>
                        int.TryParse(day, out int result) &&
                        result >= 1 && result <= 31
                    );
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
}
