using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : Controller
    {
        private readonly IProcessService _processService;

        public ProcessController(IProcessService processService)
        {
            _processService = processService;
        }
        [HttpGet("GetAllProcessByDepartmentmanagerId/{departmentManagerId}")]
        public async Task<IActionResult> GetAllProcessByDepartmentmanagerId(int departmentManagerId)
        {
            var result = await _processService.GetAllProcessByDepartmentManagerId(departmentManagerId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        
        [HttpGet("GetAllProcessDetailByDepartmentmanagerId/{departmentManagerId}")]
        public async Task<IActionResult> GetAllProcessDetailByDepartmentmanagerId(int departmentManagerId)
        {
            var result = await _processService.GetAllProcessDetailByDepartmentManagerId(departmentManagerId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("GetAllProcessDetailById/{processId}")]
        public async Task<IActionResult> GetAllProcessDetailById(int processId)
        {
            var result = await _processService.GetProcessDetail(processId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPost("CreateProcess")]
        public async Task<IActionResult> CreateProcess(ProcessCreateCommand request)
        {
            var result = await _processService.CreateProcess(request);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPost("AddProcessDetail/{processId}")]
        public async Task<IActionResult> AddProcessDetail(int processId, ICollection<VisitProcessCommand> request)
        {
            var result = await _processService.AddProcessVisit(processId, request);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
