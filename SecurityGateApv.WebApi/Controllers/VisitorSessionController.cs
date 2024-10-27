using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Models;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorSessionController : Controller
    {
        private readonly IVisitorSessionService _visitorSessionService;
        public VisitorSessionController(IVisitorSessionService visitorSessionService)
        {
            _visitorSessionService = visitorSessionService;
        }
        [HttpPut("CheckOut")]
        public async Task<ActionResult> CheckOut(VisitorSessionCheckOutCommand command, string qrCardVerifi )
        {
            var result = await _visitorSessionService.CheckOut(command, qrCardVerifi);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        
        
        [HttpPost("CheckIn")]
        public async Task<ActionResult> CheckIn([FromForm] VisitSessionCheckInCommand visitSessionCheckInCommand)
        {
            var result = await _visitorSessionService.CheckIn(visitSessionCheckInCommand);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPost("ValidCheckIn")]
        public async Task<ActionResult> ValidCheckIn([FromForm] ValidCheckInCommand validCheckInCommand)
        {
            var result = await _visitorSessionService.ValidCheckIn(validCheckInCommand);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet()]
        public async Task<IActionResult> GetAllVisitorSession(int pageNumber, int pageSize)
        {
            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitorSessionService.GetAllVisitorSession(1, int.MaxValue);
                return Ok(resultAll.Value);
            }
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _visitorSessionService.GetAllVisitorSession(pageNumber, pageSize);
            return Ok(result.Value);
        } 
        [HttpGet("Visitor/{visitorId}")]
        public async Task<IActionResult> GetAllVisitorSessionByVisitorId(int pageNumber, int pageSize, int visitorId)
        {
            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitorSessionService.GetAllVisitorSessionByVisitorId(1, int.MaxValue, visitorId);
                return Ok(resultAll.Value);
            }
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _visitorSessionService.GetAllVisitorSessionByVisitorId(pageNumber, pageSize, visitorId);
            return Ok(result.Value);
        }
        [HttpGet("Visit/{visitId}")]
        public async Task<IActionResult> GetAllVisitorSessionByVisitId(int pageNumber, int pageSize, int visitId)
        {
            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitorSessionService.GetAllVisitorSessionByVisitId(1, int.MaxValue, visitId);
                return Ok(resultAll.Value);
            }
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _visitorSessionService.GetAllVisitorSessionByVisitId(pageNumber, pageSize, visitId);
            return Ok(result.Value);
        }
        [HttpGet("CheckIn/QrCard/{qrCardVerified}")]
        public async Task<IActionResult> GetVisitSessionByQRCardVerification(string qrCardVerified)
        {
            var result = await _visitorSessionService.GetVisitSessionByQRCardVerification(qrCardVerified);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("CheckIn/CredentialId/{credentialId}")]
        public async Task<IActionResult> GetAllVisitorSessionByCredentialIdId(string credentialId)
        {
            var result = await _visitorSessionService.GetAllVisitorSessionByCredentialIdId(credentialId);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
