using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Services.Interface
{
    public interface IVisitorSessionService
    {
        public Task<Result<bool>> CheckOut(VisitorSessionCheckOutCommand command, string qrCardVerifi);
        public Task<Result<bool>> CheckIn(VisitSessionCheckInCommand command);
        public Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSession(int pageNumber, int pageSize);
        public Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSessionByVisitorId(int pageNumber, int pageSize, int VisitorId);
        public Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSessionByVisitId(int pageNumber, int pageSize, int visitId);
        public Task<Result<ICollection<GetVisitorSessionRes>>> GetVisitSessionByQRCardVerification(string qrCardVerified);
        public Task<Result<ICollection<GetVisitorSessionRes>>> GetAllVisitorSessionByCredentialIdId(string credentialId);

        
    }
}
