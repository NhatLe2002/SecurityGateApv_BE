using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : Controller
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetAllSchedule(int pageNumber, int pageSize)
        {
            var result = await _scheduleService.GetAllSchedule( pageNumber,  pageSize);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.Value);
        }

        [HttpGet("{schduleId}")]
        public async Task<IActionResult> GetScheduleById(int schduleId)
        {
            var result = await _scheduleService.GetScheduleById(schduleId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        
        [HttpPost()]
        public async Task<IActionResult> CreateSchedule([FromBody] CreateScheduleCommand request)
        {
            var result = await _scheduleService.CreateSchedule(request);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPut("{scheduleId}")]
        public async Task<IActionResult> UpdateSchedule([FromBody] UpdateScheduleCommand request,  int scheduleId)
        {
            var result = await _scheduleService.UpdateSchedule(request, scheduleId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpDelete("{scheduleId}")]
        public async Task<IActionResult> DeleteSchedule( int scheduleId)
        {
            var result = await _scheduleService.DeleteSchedule( scheduleId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
       
    }
}
