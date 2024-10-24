﻿using FluentValidation;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
using SecurityGateApv.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.Validators
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserValidator(IUserRepo userRepo, IDepartmentRepo departmentRepo)
        {
            RuleFor(x => x.UserName)
           .NotEmpty().WithMessage("UserName cannot be empty")
           .MinimumLength(3).WithMessage("UserName must be at least 3 characters long");

            RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("FullName cannot be empty");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email is not valid");

            RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("PhoneNumber cannot be empty")
            .Matches(@"^\d{10}$").WithMessage("PhoneNumber must be a 10-digit number");


            //RuleFor(x => x.DepartmentId)
            //    .NotNull().NotEmpty().Must(s =>
            //    {
            //        return departmentRepo.IsAny(x => x.DepartmentId == s).GetAwaiter().GetResult();
            //    }).WithMessage("Department Id is not exist");
        }
    }
    
}
