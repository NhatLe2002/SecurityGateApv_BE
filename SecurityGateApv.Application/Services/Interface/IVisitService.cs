using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
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
        public Task<Result<List<GetVisitByDateRes>>> GetVisitByDate(int pageSize, int pageNumber, DateTime date);
        public Task<Result<List<GetVisitNoDetailRes>>> GetAllVisit(int pageSize, int pageNumber);      
        public Task<Result<GetVisitNoDetailRes>> ReportVisit(int visitId);      
        public Task<Result<GetVisitNoDetailRes>> CancelVisit(int visitId);      
        public Task<Result<GetVisitNoDetailRes>> ActiveVisit(int visitId);      
        public Task<Result<List<GetVisitDetailRes>>> GetVisitDetailByVisitId(int visitId, int pageNumber, int pageSize);
        public Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByCreateById(int visitId, int pageNumber, int pageSize);
        public Task<Result<IEnumerable<GetVisitRes>>> GetVisitByDepartmentId(int departmentId, int pageNumber, int pageSize);
        public Task<Result<IEnumerable<GetVisitRes>>> GetVisitByUserId(int departmentManagerId, int pageNumber, int pageSize);
        public Task<Result<GetVisitRes>> GetVisitDetailByVisitId(int visitId);
        public Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByStatus(string status, int pageNumber, int pageSize);
        public Task<Result<List<GetVisitByCredentialCardRes>>> GetVisitByCurrentDateAndCredentialCard(string credentialCard, DateTime date);
        public Task<Result<VisitCreateCommand>> CreateVisit(VisitCreateCommand command, string token);
        public Task<Result<VisitCreateCommandDaily>> CreateVisitDaily(VisitCreateCommandDaily command);
        //public Task<Result<VisitCreateCommand>> UpdateVisit(int visitId, VisitCreateCommand command);
        public Task<Result<UpdateVisitBeforeStartDateCommand>> UpdateVisitBeforeStartDate(int visitId, UpdateVisitBeforeStartDateCommand command);
        public Task<Result<UpdateVisitAfterStartDateCommand>> UpdateVisitAfterStartDate(int visitId, UpdateVisitAfterStartDateCommand command);
        public Task<Result<UpdateAppendTimeForVisitCommand>> AppendTime(int visitId, UpdateAppendTimeForVisitCommand command);
        public Task<Result<bool>> DeleteVisit(int visitId);


    }
}
