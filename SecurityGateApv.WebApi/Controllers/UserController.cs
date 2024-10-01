using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Errors;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Domain.Shared;

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

        [HttpGet]
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
        
        [HttpGet("Department/{departmentId}")]
        public async Task<ActionResult> GetAllUserByDepartmentId(int pageNumber, int pageSize, int departmentId)
        {
            if ( departmentId == null)
            {
                return BadRequest(Result.Failure<List<GetUserRes>>(Error.NullInput));
            }
            var result = await _userService.GetAllUserPagingByDepartmentId(pageNumber, pageSize, departmentId);
            return Ok(result.Value);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserComman command)
        {
            var token = Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest(new Error("CreateUser", "Invalid Token"));
            }
            var result = await _userService.CreateUser(command, token);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }

        [HttpPut("{userId}")]
        public async Task<ActionResult> UpdateUser(int userId, [FromBody] CreateUserComman command)
        {
            var token = Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest(new Error("CreateUser", "Invalid Token"));
            }
            var result = await _userService.UpdateUser(userId, command, token);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpDelete("{userId}")]
        public async Task<ActionResult> UnactiveUser(int userId)
        {
            var token = Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest(new Error("CreateUser", "Invalid Token"));
            }
            var result = await _userService.UnactiveUser(userId, token);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPost("Testemail")]
        public async Task<ActionResult> TestEmail([FromQuery] string email)
        {
            var result = await _userService.SendEmailTest(email);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }

        /* [HttpPost("Staff/{departmentId}")]
         public async Task<ActionResult> CreateStaff([FromBody] CreateUserComman command, int departmentId)
         {
             var result = await _userService.CreateUser(command, departmentId, 4);

             if (result.IsFailure)
             {
                 return BadRequest(result.Error);
             }
             return Ok(result.Value);
         }


         [HttpPost("DeparmentManager/{departmentId}")]
         public async Task<ActionResult> CreateDepartmentManager([FromBody] CreateUserComman command, int departmentId)
         {
             var result = await _userService.CreateUser(command, departmentId, 3);

             if (result.IsFailure)
             {
                 return BadRequest(result.Error);
             }
             return Ok(result.Value);
         }
         [HttpPut("DeparmentManager/{departmentManagerId}")]
         public async Task<ActionResult> UpdateDepartmentManager([FromBody] CreateUserComman command, int departmentManagerId)
         {
             var result = await _userService.CreateUser(command, departmentId, 3);

             if (result.IsFailure)
             {
                 return BadRequest(result.Error);
             }
             return Ok(result.Value);
         }

         [HttpPost("Manager/{departmentId}")]
         public async Task<ActionResult> CreateManager([FromBody] CreateUserComman command, int departmentId)
         {
             var result = await _userService.CreateUser(command, departmentId, 2);

             if (result.IsFailure)
             {
                 return BadRequest(result.Error);
             }
             return Ok(result.Value);
         }

         [HttpPost("Security/{departmentId}")]
         public async Task<ActionResult> CreateSecurity([FromBody] CreateUserComman command, int departmentId)
         {
             var result = await _userService.CreateUser(command, departmentId, 5);

             if (result.IsFailure)
             {
                 return BadRequest(result.Error);
             }
             return Ok(result.Value);
         }*/
    }
}
