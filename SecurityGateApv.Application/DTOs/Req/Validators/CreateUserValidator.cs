using FluentValidation;
using SecurityGateApv.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.Validators
{
    public class CreateUserValidator: AbstractValidator<CreateUserComman>
    {
        public CreateUserValidator(IUserRepo userRepo, IDepartmentRepo departmentRepo)
        {
            RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("UserName cannot be empty")
            .MinimumLength(3).WithMessage("UserName must be at least 3 characters long")
            .Must( s =>
            {
                return !userRepo.IsAny(x => x.UserName == s).GetAwaiter().GetResult();

            }).WithMessage("Duplicate Username")
            ;

            RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password cannot be empty")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters long");

            RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("FullName cannot be empty")
            .Matches(@"^[a-zA-Z\s]+$").WithMessage("FullName can only contain letters and spaces");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email is not valid");

            RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("PhoneNumber cannot be empty")
            .Matches(@"^\d{10}$").WithMessage("PhoneNumber must be a 10-digit number");


            RuleFor(x => x.DepartmentId)
                .NotNull().NotEmpty().Must(s =>
                {
                    return departmentRepo.IsAny(x => x.DepartmentId == s).GetAwaiter().GetResult();
                }).WithMessage("Department Id is not exist");
        }
    }
}
