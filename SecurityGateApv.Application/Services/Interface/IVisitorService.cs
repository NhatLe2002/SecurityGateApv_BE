﻿using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services.Interface
{
    public interface IVisitorService
    {
        public Task<Result<List<GetVisitorRes>>> GetAllByPaging(int pageNumber, int pageSize);
        public Task<Result<GetVisitorRes>> GetById(int visitorId);
        public Task<Result<GetVisitorRes>> GetByCredentialCard(string cardNumber);
        public Task<Result<CreateVisitorRes>> CreateVisitor(CreateVisitorCommand command);
        public Task<Result<CreateVisitorCommand>> UpdateVisitor(int visitorId,CreateVisitorCommand command);
        public Task<Result<bool>> DeleteVisitor(int visitorId);
    }
}
