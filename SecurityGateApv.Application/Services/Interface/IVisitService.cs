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
        public Task<Result<List<GetVisitByDateRes>>> GetVisitByDate(int pageSize, int pageNumber, DateTime date);
        public Task<Result<List<GetVisitNoDetailRes>>> GetAllVisit(int pageSize, int pageNumber);      
        public Task<Result<List<GetVisitDetailRes>>> GetVisitDetailByVisitId(int visitId, int pageNumber, int pageSize);
        public Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByCreateById(int visitId, int pageNumber, int pageSize);
        public Task<Result<IEnumerable<GetVisitRes>>> GetVisitByDepartmentId(int departmentId, int pageNumber, int pageSize);
        public Task<Result<IEnumerable<GetVisitRes>>> GetVisitByUserId(int departmentManagerId, int pageNumber, int pageSize);
        public Task<Result<GetVisitRes>> GetVisitDetailByVisitId(int visitId);
        public Task<Result<IEnumerable<GetVisitRes>>> GetVisitDetailByStatus(string status, int pageNumber, int pageSize);
        public Task<Result<List<GetVisitByCredentialCardRes>>> GetVisitByCurrentDateAndCredentialCard(string credentialCard, DateTime date);
        public Task<Result<VisitCreateCommand>> CreateVisit(VisitCreateCommand command);
        public Task<Result<VisitCreateCommandDaily>> CreateVisitDaily(VisitCreateCommandDaily command);
        public Task<Result<VisitCreateCommand>> UpdateVisit(int visitId, VisitCreateCommand command);
        public Task<Result<bool>> DeleteVisit(int visitId);


    }
}
