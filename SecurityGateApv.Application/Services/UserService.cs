﻿using AutoMapper;
using Microsoft.AspNetCore.Identity.UI.Services;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        private readonly IEmailSender _emailSender;
        public UserService(IUserRepo userRepo, IMapper mapper, IJwt jwt, IDepartmentRepo departmentRepo,
            IRoleRepo roleRepo, IUnitOfWork unitOfWork, IEmailSender emailSender)
        {
            _userRepo = userRepo;
            _mapper = mapper;
            _jwt = jwt;
            _departmentRepo = departmentRepo;
            _roleRepo = roleRepo;
            _unitOfWork = unitOfWork;
            _emailSender = emailSender;
        }

        public Task<Result<CreateUserComman>> CreateDepartmentManager(CreateUserComman command)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<CreateUserComman>> CreateUser(CreateUserComman command, string token)
        {
            var role = _jwt.DecodeJwt(token);
            var permission = await PermissionCheck(role, command.RoleID);
            if (!permission)
            {
                return Result.Failure<CreateUserComman>(Error.NotPermission);
            }
            var department = _departmentRepo.FindAsync(s => s.DepartmentId == command.DepartmentId).Result.FirstOrDefault();
            if ((command.RoleID.Equals(UserRoleEnum.Admin)&& !department.DepartmentName.Equals(DepartmentSpecialCaseEnum.AdminDepartment.ToString()))
                || (command.RoleID.Equals(UserRoleEnum.Manager) && !department.DepartmentName.Equals(DepartmentSpecialCaseEnum.ManagerDepartment.ToString()))
                || (command.RoleID.Equals(UserRoleEnum.Security) && !department.DepartmentName.Equals(DepartmentSpecialCaseEnum.SecurityDepartment.ToString()))
                )
            {
                return Result.Failure<CreateUserComman>(Error.UserRoleNotMatchDepartment);
            }
            var userResult = User.Create(command.UserName, command.Password, command.FullName, command.Email, command.PhoneNumber, command.Image, DateTime.Now, DateTime.Now,
                    UserStatusEnum.Active.ToString(), command.RoleID, command.DepartmentId);
            if (userResult.IsFailure)
            {
                return Result.Failure<CreateUserComman>(userResult.Error);
            }
            await _userRepo.AddAsync(userResult.Value);
            await _unitOfWork.CommitAsync();
            await _emailSender.SendEmailAsync(userResult.Value.Email, "Welcome to APV security", "Xin chao a !");

            return command;
        }

        public async Task<Result<List<GetUserRes>>> GetAllUserPagingByDepartmentId(int pageNumber, int pageSize, int departmentId)
        {
            var department = (await _departmentRepo.FindAsync(
            s => s.DepartmentId == departmentId
                )).FirstOrDefault();
            if (department == null)
            {
                return Result.Failure<List<GetUserRes>>(Error.NotFoundDepartment);
            }
            var user = await _userRepo.FindAsync(
                    s => s.DepartmentId == department.DepartmentId,
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
                    pageSize, pageNumber, includeProperties: "Role,Department"
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
            var user = new List<User>();
            if (role == "All")
            {
                user = (await _userRepo.FindAsync(
                    s => true,
                    pageSize, pageNumber, includeProperties: "Role,Department"
                    )).ToList();
            }
            else
            {
                user = (await _userRepo.FindAsync(
                    s => s.Role.RoleName.Equals(role),
                    pageSize, pageNumber, includeProperties: "Role,Department"
                    )).ToList();
            }

            if (user.Count() == 0)
            {
                return Result.Failure<List<GetUserRes>>(Error.NotFoundUser);
            }
            var result = _mapper.Map<List<GetUserRes>>(user);
            return result;
        }

        public async Task<Result<LoginRes>> Login(LoginModel loginModel)
        {
            var login = (await _userRepo.FindAsync(s => s.UserName == loginModel.Username, includeProperties: "Role,Department")).FirstOrDefault();
            if (login == null)
            {
                return Result.Failure<LoginRes>(Error.NotFoundUser);
            }
            if (login.Password != loginModel.Password)
            {
                return Result.Failure<LoginRes>(Error.IncorrectPassword);
            }
            var result = new LoginRes
            {
                UserId = login.UserId,
                UserName = login.UserName,
                JwtToken = _jwt.GenerateJwtToken(login)
            };
            return result;
        }

        public async Task<Result<bool>> SendEmailTest(string email)
        {
            await _emailSender.SendEmailAsync(email, "Test subject", "haha");
            return true;
        }

        public async Task<Result<bool>> UnactiveUser(int userId, string token)
        {

            var user = (await _userRepo.FindAsync(s => s.UserId == userId)).FirstOrDefault();
            if (user == null)
            {
                return Result.Failure<bool>(Error.NotFoundUser);
            }
            var role = _jwt.DecodeJwt(token);
            var permission = await PermissionCheck(role, user.RoleId);
            if (!permission)
            {
                return Result.Failure<bool>(Error.NotPermission);
            }
            user.Unactive();
            await _userRepo.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
            return true;
        }

        public async Task<Result<UpdateUserCommand>> UpdateUser(int userId, UpdateUserCommand command, string token)
        {
            // Decode the JWT token to get the role of the user making the request
            var role = _jwt.DecodeJwt(token);

            // Check if the user has permission to update the specified role
            var permission = await PermissionCheck(role, command.RoleID);
            if (!permission)
            {
                return Result.Failure<UpdateUserCommand>(Error.NotPermission);
            }

            // Retrieve the user by userId from the repository
            var user = (await _userRepo.FindAsync(s => s.UserId == userId)).FirstOrDefault();
            if (user == null)
            {
                return Result.Failure<UpdateUserCommand>(Error.NotFoundUser);
            }

            // Check if the username in the command matches the existing username of the user
            if (user.UserName != command.UserName)
            {
                return Result.Failure<UpdateUserCommand>(Error.CanNotUpdateUserName);
            }

            var department = _departmentRepo.FindAsync(s => s.DepartmentId == command.DepartmentId).Result.FirstOrDefault();
            // If the user's role is not Admin, Manager, or Security, check the department
            if (user.RoleId == (int)UserRoleEnum.Staff ||
                user.RoleId == (int)UserRoleEnum.DepartmentManager )
            {
                // Check if the specified DepartmentId in the command exists in the repository
                if (department == null 
                    || department.DepartmentName.Equals(DepartmentSpecialCaseEnum.AdminDepartment.ToString())
                    || department.DepartmentName.Equals(DepartmentSpecialCaseEnum.ManagerDepartment.ToString())
                    || department.DepartmentName.Equals(DepartmentSpecialCaseEnum.SecurityDepartment.ToString()))
                {
                    return Result.Failure<UpdateUserCommand>(Error.NotFoundDepartment);
                }
            }
            if (user.RoleId == (int)UserRoleEnum.Admin 
                || user.RoleId == (int)UserRoleEnum.Manager
                || user.RoleId == (int)UserRoleEnum.Security)
            {
                if(command.DepartmentId != null )
                {
                    return Result.Failure<UpdateUserCommand>(Error.CanNotUpdateDepartment);
                }
            }


            // Map the properties from the command to the user object
            var result = _mapper.Map(command, user);

            // Call the Update method on the user object to apply any additional logic required for updating
            user.Update();

            // Update the user in the repository and commit the changes to the database
            if(!await _userRepo.UpdateAsync(result))
            {
                return Result.Failure<UpdateUserCommand>(Error.UpdateDepartment);
            }
            try
            {
                if (!await _unitOfWork.CommitAsync())
                {
                    return Result.Failure<UpdateUserCommand>(Error.UpdateDepartment);
                }
            }
            catch (Exception ex)
            {
                // Log exception details here
                Console.WriteLine($"Error committing changes: {ex.Message}");
                return Result.Failure<UpdateUserCommand>(Error.UpdateDepartment);
            }

            return command;
        }
        private async Task<bool> PermissionCheck(string userRole, int checkRole)
        {
            if (userRole == UserRoleEnum.Manager.ToString() && checkRole == (int)UserRoleEnum.DepartmentManager)
            {
                return true;
            }
            else
            if (userRole == UserRoleEnum.DepartmentManager.ToString() && checkRole == (int)UserRoleEnum.Staff)
            {
                return true;
            }
            else
            if (userRole == UserRoleEnum.Admin.ToString())
            {
                return true;
            }
            else
            if (userRole == UserRoleEnum.Manager.ToString() && checkRole == (int)UserRoleEnum.Security)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Result<GetUserRes>> GetUserById(int userId)
        {
            var user = (await _userRepo.FindAsync(s => s.UserId == userId, includeProperties: "Role,Department")).FirstOrDefault();
            if (user == null)
            {
                return Result.Failure<GetUserRes>(Error.NotFoundUser);
            }
            return _mapper.Map<GetUserRes>(user);
        }

        public async Task<Result<bool>> UpdateUserPassword(int userId, UpdateUserPasswordCommand command)
        {
            var user = (await _userRepo.FindAsync(s => s.UserId == userId)).FirstOrDefault();
            if (user == null)
            {
                return Result.Failure<bool>(Error.NotFoundUser);
            }
            if (user.Password != command.OldPassword)
            {
                return Result.Failure<bool>(Error.PasswordNotMatch);
            }
            if (command.NewPassword != command.NewPasswordCheck)
            {
                return Result.Failure<bool>(Error.CheckPasswordError);
            }
            user.UpdatePassword(command.NewPassword);
            await _userRepo.UpdateAsync(user);
            var commit = await _unitOfWork.CommitAsync();
            if (!commit)
            {
                return Result.Failure<bool>(Error.CommitError);
            }
            return true;
        }

        public async Task<Result<UpdateUserNoDepartmentIdCommand>> UpdateUserNodepartmentId(int userId, UpdateUserNoDepartmentIdCommand command, string token)
        {
            var user = (await _userRepo.FindAsync(s => s.UserId == userId)).FirstOrDefault();
            if (user == null)
            {
                return Result.Failure<UpdateUserNoDepartmentIdCommand>(Error.NotFoundUser);
            }
            if (user.UserName != command.UserName)
            {
                return Result.Failure<UpdateUserNoDepartmentIdCommand>(Error.CanNotUpdateUserName);
            }
            user = _mapper.Map(command, user);
            user.Update();
            await _userRepo.UpdateAsync(user);
            await _unitOfWork.CommitAsync();
            return command;
        }
    }
}
