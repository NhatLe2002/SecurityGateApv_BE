using AutoMapper;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Interfaces.Jwt;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;
        private readonly IJwt _jwt;
        public UserService(IUserRepo userRepo, IMapper mapper, IJwt jwt) {
            _userRepo = userRepo;
            _mapper = mapper;
            _jwt = jwt;
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
