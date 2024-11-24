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
    public interface IGateService
    {
        public Task<Result<List<GetGateRes>>> GetAllGate();
        public Task<Result<List<CameraTypeRes>>> GetAllCameraType();
        public Task<Result<List<GetGateRes>>> GetAllGatePaging(int pageSize, int pageNumber);
        public Task<Result<bool>> CreateGate(CreateGateCommand command);
        public Task<Result<List<CameraRes>>> GetCameraByGate(int gate);


    }
}
