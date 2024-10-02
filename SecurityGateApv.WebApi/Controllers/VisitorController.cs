using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : Controller
    {
        private readonly IVisitorService _visitorService;

        //private readonly IVisitorService _visitorService
        public VisitorController(IVisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllVisitor(int pageNumber, int pageSize)
        {
            var result = await _visitorService.GetAllByPaging(pageNumber, pageSize);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateVisitor([FromBody] IFormFile image,[FromQuery] CreateVisitorCommand command)
        {
            command.VisitorCredentialImage = image;
            var result = await _visitorService.CreateVisitor(command);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPut("{visitorId}")]
        public async Task<IActionResult> CreateVisitor(int visitorId, [FromBody] IFormFile image, [FromQuery] CreateVisitorCommand command)
        {
            command.VisitorCredentialImage = image;
            var result = await _visitorService.CreateVisitor(command);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpDelete("{visitorId}")]
        public async Task<IActionResult> DeleteVisitor(int visitorId)
        {
            var result = await _visitorService.DeleteVisitor(visitorId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
