using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorSessionController : Controller
    {
        private readonly IVisitService _visitService;
        public VisitorSessionController(IVisitService visitService)
        {
            _visitService = visitService;
        }
        [HttpPost("CheckOut")]
        public async Task<ActionResult> CheckOut(VisitCreateCommand command)
        {
            var result = await _visitService.CreateVisit(command);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
