using FluentValidation;
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
           .MinimumLength(3).WithMessage("Tên người dùng phải lớn hơn 3 kí tự");

            RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("FullName cannot be empty")
            .Matches(@"^[A-Za-zàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]+(?:[-'\s.][A-Za-zàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]+)+$").WithMessage("Tên người dùng chỉ bao gồm chữ và 2 từ trở lên"); ;

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email không hợp lệ");

            RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("PhoneNumber cannot be empty")
                           .Matches(@"^(0\d{9})$").WithMessage("Số điện thoại phải đúng 10 số và bắt đầu bằng số 0");

            RuleFor(x => x.DepartmentId)
                .NotNull().NotEmpty().Must(s =>
                {
                    return departmentRepo.IsAny(x => x.DepartmentId == s).GetAwaiter().GetResult();
                }).WithMessage("Department Id is not exist");
        }
    }
    
}
