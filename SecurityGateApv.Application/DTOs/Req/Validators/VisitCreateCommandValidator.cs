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
        public VisitCreateCommandValidator(IUserRepo userRepo)
        {
            RuleFor(s => s.AcceptLevel).Must(s => s > 0).NotNull();
            RuleFor(s => s.VisitQuantity).Must(s => s > 0).NotNull();
            RuleFor(s => s.CreateById).Must(s =>
            {
                var user = userRepo.FindAsync(t => t.UserId == s).GetAwaiter().GetResult();
                if(user != null)
                {
                    return true;
                }
                return false;
            });
            RuleFor(s => s.UpdateById).Must(s =>
            {
                var user = userRepo.FindAsync(t => t.UserId == s).GetAwaiter().GetResult();
                if (user != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("User Id not exist");
/*            RuleForEach(s => s.VisitProject).Must(s =>
            {
                if(s == null)
                {
                    return true;
                }
                var project = projectRepo.FindAsync(t => t.ProjectId == s.ProjectId).GetAwaiter().GetResult();
                if (project != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Project Id not exist");*/
/*            RuleFor(s => s.DepartmentReasonId).Must(s =>
            {
                var deReason = departmentReasonRepo.FindAsync(t => t.DepartmentReasonId == s).GetAwaiter().GetResult();
                if (deReason != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("DeparmentReason Id not exist");*/
        }
        class VisitDetailCommandValidator : AbstractValidator<VisitDetailCommand>
        {
            public VisitDetailCommandValidator(IVisitorRepo visitorRepo)
            {
                /*RuleFor(s => s.ExpectedTimeOut).NotEmpty().Must(s =>
                {
                    if(s > DateTime.Now)
                    {
                        return true;
                    }
                    return false;
                });
                RuleFor(s => s.ExpectedTimeIn).NotEmpty().Must(s =>
                {
                    if (s > DateTime.Now)
                    {
                        return true;
                    }
                    return false;
                });*/
                RuleFor(s => new { s.ExpectedTimeIn, s.ExpectedTimeOut }).Must(s =>
                {
                    if (s.ExpectedTimeIn < s.ExpectedTimeOut)
                    {
                        return true;
                    }
                    return false;
                });
                RuleFor(s => s.Description).NotEmpty().NotNull();
                RuleFor(s => s.Visitor).Must(s =>
                {
                    var visitor = visitorRepo.FindAsync(t => t.CredentialsCard == s.CredentialsCard).GetAwaiter().GetResult();
                    if(visitor != null)
                    {
                        return false;
                    }
                    if(s.CreatedDate < DateTime.Now && s.UpdatedDate < DateTime.Now && String.IsNullOrEmpty(s.CompanyName) && String.IsNullOrEmpty(s.VisitorName))
                    {
                        return false;
                    }

                    return true;
                
                });
            }
        }
    }
}
