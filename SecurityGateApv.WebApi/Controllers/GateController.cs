using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GateController : Controller
    {
        private readonly IGateService _gateService;
        public GateController(IGateService gateService)
        {
            _gateService = gateService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllGate()
        {
            var result = await _gateService.GetAllGate();
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        //[HttpPost()]
        //public async Task<IActionResult> CreateCard(CreateCardCommand command)
        //{
        //    var result = await _gateService.Create(command);
        //    if (result.IsFailure)
        //    {
        //        return BadRequest(result.Error);
        //    }
        //    return Ok(result.Value);
        //}
        [HttpGet("GetAllGatePaging")]
        public async Task<ActionResult> GetAllGatePaging(int pageSize, int pageNumber)
        {
            var result = await _gateService.GetAllGatePaging(pageSize, pageNumber);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        } 
        
        [HttpGet("TestTime")]
        public ActionResult TestTime()
        {
            return Ok(DateTime.Now);
        }
    }
}
