using FluentValidation;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.Validators
{
    public class ProcessCreateValidator : AbstractValidator<ProcessCreateCommand>
    {
        public ProcessCreateValidator(IVisitTypeRepo visitTypeRepo, IUserRepo userRepo)
        {
            RuleFor(s=>s.ProcessName).NotEmpty().NotNull();
            RuleFor(s => s.Status).NotEmpty().NotNull();
            RuleFor(s => s.Description).NotEmpty().NotNull();
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
    public class VisitProcessCreateValidator : AbstractValidator<VisitProcessCommand>
    {
        public VisitProcessCreateValidator(IVisitTypeRepo visitTypeRepo, IUserRepo userRepo)
        {
            RuleFor(s => s.ExpectedStartTime).NotEmpty().NotNull();
            RuleFor(s => s.ExpectedEndTime).NotEmpty().NotNull();
            RuleFor(s => s.ExpectedStartDate).NotEmpty().NotNull();
            RuleFor(s => s.ExpectedEndDate).NotEmpty().NotNull();
            RuleFor(s => s.VisitQuantity).NotEmpty().NotNull().Must(s=>s>0);
            RuleFor(s => s.Status).NotEmpty().NotNull();
        }
    }
}
