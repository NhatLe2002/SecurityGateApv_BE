using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services.Interface
{
    public interface IVisitService
    {
        public Task<Result<List<GetVisitNoDetailRes>>> GetAllVisit( );
        public Task<Result<List<GetVisitByDateRes>>> GetVisitByDate(int pageSize, int pageNumber, DateTime date);
        public Task<Result<List<GetVisitRes>>> GetAllByFilterOrderbyIncludePaging(QueryParameters<Visit> queryParameters);
        public Task<Result<List<GetVisitNoDetailRes>>> GetAllByPaging(int pageNumber, int pageSize);
        public Task<Result<List<GetVisitDetailRes>>> GetVisitDetailByVisitId(int visitId, int pageNumber, int pageSize);
        public Task<Result<List<GetVisitByDateRes>>> GetVisitByCredentialCard(string credentialCard);
        public Task<Result<VisitCreateCommand>> CreateVisit(VisitCreateCommand command);
        public Task<Result<VisitCreateCommand>> CreateVisitOfProcess(int processVisitId, VisitCreateCommand command, bool visitType);


    }
}
