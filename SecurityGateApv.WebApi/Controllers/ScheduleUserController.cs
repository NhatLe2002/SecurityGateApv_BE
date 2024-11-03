using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleUserController : Controller
    {
        private readonly IScheduleUserService _scheduleUserService;

        public ScheduleUserController(IScheduleUserService scheduleUserService)
        {
            _scheduleUserService = scheduleUserService;
        }
        //[HttpGet()]
        //public async Task<IActionResult> GetAllSchedule(int pageNumber, int pageSize)
        //{
        //    var result = await _scheduleUserService.GetAllSchedule(pageNumber, pageSize);
        //    if (result.IsFailure)
        //    {
        //        return BadRequest(result.Error);
        //    }

        //    return Ok(result.Value);
        //}
        [HttpGet("UserId/{userId}")]
        public async Task<IActionResult> GetScheduleUserByUserId(int userId, int pageNumber, int pageSize)
        {
            var result = await _scheduleUserService.GetScheduleUserByUserId(userId, pageNumber, pageSize);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.Value);
        } 
        [HttpGet("Assigned/UserId/{userId}")]
        public async Task<IActionResult> GetScheduleAssignedUserByUserId(int userId, int pageNumber, int pageSize)
        {
            var result = await _scheduleUserService.GetScheduleAssignedUserByUserId(userId, pageNumber, pageSize);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.Value);
        }
        [HttpPost()]
        public async Task<IActionResult> CreateScheduleUser([FromBody] CreateScheduleUserCommand request)
        {
            var result = await _scheduleUserService.CreateScheduleUser(request);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPut("Reject/ScheduleId/{scheduleId}")]
        public async Task<IActionResult> RejectScheduleUser(int scheduleId)
        {
            var result = await _scheduleUserService.RejectScheduleUser(scheduleId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPut("Aprove/ScheduleId/{scheduleId}")]
        public async Task<IActionResult> AproveScheduleUser(int scheduleId)
        {
            var result = await _scheduleUserService.AproveScheduleUser(scheduleId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
