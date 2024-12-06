using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        [HttpGet("Visit")]
        public async Task<IActionResult> GetVisit()
        {
            return Ok((await _dashboardService.GetVisit()).Value);
        }
        [HttpGet("User")]
        public async Task<IActionResult> GetUser()
        {
            return Ok((await _dashboardService.GetUser()).Value);
        }
        [HttpGet("Visitor")]
        public async Task<IActionResult> GetVisitor()
        {
            return Ok((await _dashboardService.GetVisitor()).Value);
        }
        [HttpGet("Schedule")]
        public async Task<IActionResult> GetSchedule()
        {
            return Ok((await _dashboardService.GetSchedule()).Value);
        }
        [HttpGet("ScheduleUser")]
        public async Task<IActionResult> GetScheduleUser(int? staffId)
        {
            var result = await _dashboardService.GetMission(staffId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
