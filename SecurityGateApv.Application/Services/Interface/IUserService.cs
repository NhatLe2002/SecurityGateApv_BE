using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services.Interface
{
    public interface IUserService
    {
        public Task<Result<LoginRes>> Login(LoginModel loginModel);
        public Task<Result<List<GetUserRes>>> GetUserByRolePaging(int pageNumber, int pageSize, string role);
        public Task<Result<List<GetUserRes>>> GetAllStaffPagingByDepartmentId(int pageNumber, int pageSize, int  departmentManagerId);
        public Task<Result<CreateUserComman>> CreateStaff(CreateUserComman command, int departmentManagerId);
        public Task<Result<CreateUserComman>> CreateDepartmentManager(CreateUserComman command);

    }
}
