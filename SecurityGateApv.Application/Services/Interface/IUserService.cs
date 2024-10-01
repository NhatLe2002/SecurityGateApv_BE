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
        public Task<Result<List<GetUserRes>>> GetAllStaffPagingByDepartmentId(int pageNumber, int pageSize, int  departmentId);
        public Task<Result<List<GetUserRes>>> GetAllStaffPagingByDepartmentManagerId(int pageNumber, int pageSize, int  departmentManagerId);
        public Task<Result<CreateUserComman>> CreateUser(CreateUserComman command, string token);
        public Task<Result<CreateUserComman>> UpdateUser(int userId, CreateUserComman command, string token);
        public Task<Result<bool>> UnactiveUser(int userId, string token);
        public Task<Result<bool>> SendEmailTest(string email);
    }
}
