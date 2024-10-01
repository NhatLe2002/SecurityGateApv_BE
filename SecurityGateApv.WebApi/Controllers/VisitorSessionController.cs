using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
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
        public async Task<ActionResult> CheckOut(VisitorSessionCheckOutCommand command, int qrCardId)
        {
            var result = await _visitorSessionService.CheckOut(command, qrCardId);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        
        
        [HttpPost("CheckIn")]
        public async Task<ActionResult> CheckIn(VisitSessionCheckInCommand visitSessionCheckInCommand)
        {
            var result = await _visitorSessionService.CheckIn(visitSessionCheckInCommand);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
