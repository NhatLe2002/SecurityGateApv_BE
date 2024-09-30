﻿using AutoMapper;
using SecurityGateApv.Application.DTOs.Res;
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
    public class DepartmentService : IDepartmentService
    {

        private readonly IDepartmentRepo _departmentRepo1;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentService( IMapper mapper, IUnitOfWork unitOfWork, IDepartmentRepo departmentRepo)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _departmentRepo1 = departmentRepo;
        }
        public async Task<Result<List<GetDepartmentRes>>> GetAllByPaging(int pageNumber, int pageSize)
        {
            var departments = await _departmentRepo1.FindAsync(
                s => true, pageSize, pageNumber
                );
            var result = _mapper.Map<List<GetDepartmentRes>>(departments);

            if (result.Count == 0)
            {
                return Result.Failure<List<GetDepartmentRes>>(Error.NotFoundDepartment);
            }
            return result;
        }
    }
}