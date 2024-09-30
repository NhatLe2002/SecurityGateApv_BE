using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody]LoginModel loginModel)
        {
            var result = await _userService.Login(loginModel);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }

        [HttpGet()]
        public async Task<ActionResult> GetAllUserPaging(int pageNumber, int pageSize, string role)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _userService.GetUserByRolePaging(pageNumber, pageSize, role);
            return Ok(result.Value);
        }
        [HttpGet("Staff/DepartmentManager/{departmentManagerId}")]
        public async Task<ActionResult> GetAllStaffPagingByDepartmentManagerId(int pageNumber, int pageSize, int departmentManagerId)
        {
            if (pageNumber <= 0 || pageSize <= 0 || departmentManagerId == null)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _userService.GetAllStaffPagingByDepartmentManagerId(pageNumber, pageSize, departmentManagerId);
            return Ok(result.Value);
        } 
        
        [HttpGet("Staff/Department/{departmentId}")]
        public async Task<ActionResult> GetAllStaffPagingByDepartmentId(int pageNumber, int pageSize, int departmentId)
        {
            if (pageNumber <= 0 || pageSize <= 0 || departmentId == null)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _userService.GetAllStaffPagingByDepartmentId(pageNumber, pageSize, departmentId);
            return Ok(result.Value);
        }
        [HttpPost("Staff/{departmentId}")]
        public async Task<ActionResult> CreateStaff([FromBody] CreateUserComman command, int departmentId)
        {
            var result = await _userService.CreateStaff(command, departmentId);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }

    }
}
