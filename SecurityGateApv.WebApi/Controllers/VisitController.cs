﻿using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("{visitId}")]
        public async Task<ActionResult> GetVisitDetailByVisitId(int visitId)
        {
            var result = await _visitService.GetVisitDetailByVisitId(visitId);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("Status")]
        public async Task<ActionResult> GetVisitDetailByStatus([FromQuery] string status, [FromQuery] int pageNumber, [FromQuery] int pageSize)
        {

            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitService.GetVisitDetailByStatus(status, 1, int.MaxValue);
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
            var result = await _visitService.GetVisitDetailByStatus(status, pageNumber,  pageSize);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("CreateBy/{createById}")]
        public async Task<ActionResult> GetVisitDetailByCreateById(int createById,[FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitService.GetVisitDetailByCreateById(createById, 1, int.MaxValue);
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
            var result = await _visitService.GetVisitDetailByCreateById(createById, pageNumber, pageSize);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("DepartmentId/{departmentId}")]
        public async Task<ActionResult> GetVisitDetailByDepartmentIdId(int departmentId, [FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitService.GetVisitByDepartmentId(departmentId, 1, int.MaxValue);
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
            var result = await _visitService.GetVisitByDepartmentId(departmentId, pageNumber, pageSize);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("UserId/{userId}")]
        public async Task<ActionResult> GetVisitByUserId(int userId, [FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitService.GetVisitByUserId(userId, 1, int.MaxValue);
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
            var result = await _visitService.GetVisitByUserId(userId, pageNumber, pageSize);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("Day")]
        public async Task<ActionResult> GetAllVisitsByDate([FromQuery] int pageSize, [FromQuery] int pageNumber, [FromQuery] DateTime date)
        {
            if (pageNumber == -1 || pageSize == -1)
            {
                var resultAll = await _visitService.GetVisitByDate(int.MaxValue, 1, date);
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
            var result = await _visitService.GetVisitByDate(pageSize, pageNumber, date);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("VisitDetail/{visitId}")]
        public async Task<ActionResult> GetVisitDetailByVisitId(int visitId, int pageNumber, int pageSize)
        {
            var result = await _visitService.GetVisitDetailByVisitId(visitId,  pageNumber,  pageSize);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
       
        [HttpGet("CurrentDate/CredentialCard/{credentialCard}")]
        public async Task<ActionResult> GetVisitByCurrentDateAndCredentialCard( string credentialCard, [FromQuery] DateTime date)
        {
            var result = await _visitService.GetVisitByCurrentDateAndCredentialCard(credentialCard, date);

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
        [HttpPost("Daily")]
        public async Task<ActionResult> CreateVisitDaily(VisitCreateCommandDaily command)
        {
            var result = await _visitService.CreateVisitDaily(command);

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
        [HttpDelete("{visitId}")]
        public async Task<ActionResult> DeleteVisit(int visitId)
        {
            var result = await _visitService.DeleteVisit(visitId);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
       
    }
}
