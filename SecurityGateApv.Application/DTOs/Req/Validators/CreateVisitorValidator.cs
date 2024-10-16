﻿using FluentValidation;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req.Validators
{
    public class CreateVisitorValidator : AbstractValidator<CreateVisitorCommand>
    {
        public CreateVisitorValidator(ICredentialCardTypeRepo credentialCardTypeRepo, IVisitorRepo visitorRepo)
        {
            RuleFor(s =>s.VisitorName).NotNull().NotEmpty();
            RuleFor(s => s.CompanyName).NotNull().NotEmpty();
            RuleFor(s => s.CredentialsCard).NotNull().NotEmpty().Must(s =>
            {
                if(visitorRepo.IsAny(t => t.CredentialsCard == s).GetAwaiter().GetResult())
                {
                    return false;
                }
                return true;
            }).WithMessage("This credential Card is exist");
            RuleFor(s => s.PhoneNumber).NotNull().NotEmpty()
                           .Matches(@"^\d{10}$").WithMessage("PhoneNumber must be a 10-digit number"); 
            RuleFor(s => s.CredentialCardTypeId).NotNull().NotEmpty().Must(s => {
                return credentialCardTypeRepo.IsAny(t => t.CredentialCardTypeId == s).GetAwaiter().GetResult();
            }).WithMessage("Credential card type not found");
            RuleFor(s => s.VisitorCredentialImageFromRequest).NotNull().NotEmpty();

        }
    }
}
