using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitController : Controller
    {
        private readonly IVisitService _visitService;
        public VisitController(IVisitService visitService)
        {
            _visitService = visitService;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllVisits([FromQuery]int pageSize, [FromQuery] int pageNumber)
        {
            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitService.GetAllVisit(int.MaxValue, 1);
                if (resultAll.IsFailure)
                {
                    return BadRequest(resultAll.Error);
                }
                return Ok(resultAll.Value);
            }
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }
            var result = await _visitService.GetAllVisit(pageSize, pageNumber);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
       
        
        [HttpGet("GetAllVisitsByCurrentDate")]
        public async Task<ActionResult> GetAllVisitsByCurrentDate(int pageSize, int pageNumber)
        {
            var result = await _visitService.GetVisitByCurrentDate(pageSize, pageNumber);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }

        [HttpGet("VisitDetail/{visitId}")]
        public async Task<ActionResult> GetVisitDetailByVisitId(int visitId)
        {
            var result = await _visitService.GetVisitDetailByVisitId(visitId);

            if (result.IsFailure)
            {
                return BadRequest(result.Error); 
            }

            return Ok(result.Value);
        }
        [HttpGet("GetVisitByCredentialCard/{credentialCard}")]
        public async Task<ActionResult> GetVisitByCredentialCard(string credentialCard)
        {
            var result = await _visitService.GetVisitByCredentialCard(credentialCard);

            if (result.IsFailure)
            {
                return BadRequest(result.Error); 
            }

            return Ok(result.Value);
        }
        [HttpPost]
        public async Task<ActionResult> CreateVisit(VisitCreateCommand command)
        {
            var result = await _visitService.CreateVisit(command);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPut("{visitId}")]
        public async Task<ActionResult> UpdateVisit(int visitId, VisitCreateCommand command)
        {
            var result = await _visitService.UpdateVisit(visitId, command);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        /*        [HttpPost("CreateVisitOfProcess/{visitProcessId}")]
                public async Task<ActionResult> CreateVisitOfProcess(int visitProcessId, VisitCreateCommand command)
                {
                    var result = await _visitService.CreateVisitOfProcess(visitProcessId, command, true);

                    if (result.IsFailure)
                    {
                        return BadRequest(result.Error);
                    }

                    return Ok(result.Value);
                }
                [HttpPost("CreateVisitOfProject/{visitProcessId}")]
                public async Task<ActionResult> CreateVisitOfProject(int visitProcessId, VisitCreateCommand command)
                {
                    var result = await _visitService.CreateVisitOfProcess(visitProcessId, command, false);

                    if (result.IsFailure)
                    {
                        return BadRequest(result.Error);
                    }

                    return Ok(result.Value);
                }*/
    }
}
