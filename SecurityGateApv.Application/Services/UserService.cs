using AutoMapper;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.Jwt;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IDepartmentRepo _departmentRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IMapper _mapper;
        private readonly IJwt _jwt;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUserRepo userRepo, IMapper mapper, IJwt jwt, IDepartmentRepo departmentRepo, IRoleRepo roleRepo, IUnitOfWork unitOfWork) {
            _userRepo = userRepo;
            _mapper = mapper;
            _jwt = jwt;
            _departmentRepo = departmentRepo;
            _roleRepo = roleRepo;
            _unitOfWork = unitOfWork;   
        }

        public Task<Result<CreateUserComman>> CreateDepartmentManager(CreateUserComman command)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<CreateUserComman>> CreateStaff(CreateUserComman command, int departmentId)
        {
           /* var user = await _userRepo.GetByIdAsync(userId);
            if (user == null)
            {
                return Result.Failure<CreateUserComman>(Error.NotFoundUser);
            }*/
            //var dMrole = await _roleRepo.GetByIdAsync(user.RoleId);
            /*if (dMrole.RoleName.Equals(UserRoleEnum.Staff.ToString())
                || dMrole.RoleName.Equals(UserRoleEnum.Security.ToString()))
            {
                return Result.Failure<CreateUserComman>(Error.CreateStaffError);
            }*/
            var userResult = User.Create(command.UserName, command.Password, command.FullName, command.Email, command.PhoneNumber, command.Image, DateTime.Now, DateTime.Now, UserStatusEnum.Active.ToString(), 4, departmentId);
            if (userResult.IsFailure)
            {
                return Result.Failure<CreateUserComman>(userResult.Error);
            }

            await _userRepo.AddAsync(userResult.Value);
            await _unitOfWork.CommitAsync();
            return command;
        }

        public async Task<Result<List<GetUserRes>>> GetAllStaffPagingByDepartmentId(int pageNumber, int pageSize, int departmentId)
        {
            var department = (await _departmentRepo.FindAsync(
                    s => s.DepartmentId == departmentId
                )).FirstOrDefault();
            if (department == null)
            {
                return Result.Failure<List<GetUserRes>>(Error.NotFoundDepartment);
            }
            var user = await _userRepo.FindAsync(
                    s => s.DepartmentId == department.DepartmentId && s.Role.RoleName.Equals(UserRoleEnum.Staff.ToString()),
                    pageSize, pageNumber, includeProperties: "Role"
                );
            if (user.Count() == 0)
            {
                return Result.Failure<List<GetUserRes>>(Error.NotFoundUser);
            }
            var result = _mapper.Map<List<GetUserRes>>(user);
            return result;
        }

        public async Task<Result<List<GetUserRes>>> GetAllStaffPagingByDepartmentManagerId(int pageNumber, int pageSize, int departmentManagerId)
        {
            var department = (await _departmentRepo.FindAsync(
                     s => s.User.Any(u => u.UserId == departmentManagerId)
                 )).FirstOrDefault();
            var user = await _userRepo.FindAsync(
                    s => s.DepartmentId == department.DepartmentId && s.Role.RoleName.Equals(UserRoleEnum.Staff.ToString()),
                    pageSize, pageNumber, includeProperties: "Role"
                );
            if (user.Count() == 0)
            {
                return Result.Failure<List<GetUserRes>>(Error.NotFoundUser);
            }
            var result = _mapper.Map<List<GetUserRes>>(user);
            return result;
        }

        public async Task<Result<List<GetUserRes>>> GetUserByRolePaging(int pageNumber, int pageSize, string role)
        {
            var user = await _userRepo.FindAsync(
                    s => s.Role.RoleName.Equals(role),
                    pageSize, pageNumber,includeProperties: "Role"
                );
            if(user.Count() == 0)
            {
                return  Result.Failure<List<GetUserRes>>(Error.NotFoundUser);
            }
            var result = _mapper.Map<List<GetUserRes>>( user );
            return result;
        }

        public async Task<Result<LoginRes>> Login(LoginModel loginModel)
        {
            var login = (await _userRepo.FindAsync(s => s.UserName == loginModel.Username, includeProperties: "Role")).FirstOrDefault();
            if (login == null)
            {
                return Result.Failure<LoginRes>(Error.NotFoundUser);
            }
            if(login.Password != loginModel.Password)
            {
                return Result.Failure<LoginRes>(Error.IncorrectPassword);
            }
            var result = new LoginRes
            {
                UserId = login.UserId,
                UserName = login.UserName,
                JwtToken = _jwt.GenerateJwtToken(login.Role.RoleName)
            };
            return result;
        }
    }
}
