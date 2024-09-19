using AutoMapper;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Errors;
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
        public UserService(IUserRepo userRepo, IMapper mapper) {
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public async Task<Result<LoginModel>> Login(LoginModel loginModel)
        {
            var login = (await _userRepo.FindAsync(s => s.UserName == loginModel.Email)).FirstOrDefault();
            if (login == null)
            {
                return Result.Failure<LoginModel>(Error.NotFoundUser);
            }
            if(login.Password != loginModel.Password)
            {
                return Result.Failure<LoginModel>(Error.IncorrectPassword);
            }
            return loginModel;
        }
    }
}
