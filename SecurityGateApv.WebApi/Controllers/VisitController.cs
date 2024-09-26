﻿using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Models;

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
        public async Task<ActionResult<List<GetVisitRes>>> GetVisits()
        {
            var result = await _visitService.GetAllVisit();
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("GetAllPaging")]
        public async Task<ActionResult> GetAllPaging([FromQuery] int pageNumber , [FromQuery] int pageSize)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _visitService.GetAllByPaging(pageNumber, pageSize);
            return Ok(result.Value);
        }
        [HttpGet("GetVisitDetailByVisitId/{visitId}")]
        public async Task<ActionResult> GetVisitDetailByVisitId(int visitId)
        {
            var result = await _visitService.GetVisitDetailByVisitId(visitId);

            if (result.IsFailure)
            {
                return BadRequest(result.Error); 
            }

            return Ok(result.Value);
        }
        [HttpPost("CreateVisit")]
        public async Task<ActionResult> CreateVisit(VisitCreateCommand command)
        {
            var result = await _visitService.CreateVisit(command);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpPost("CreateVisitOfProcess/{visitProcessId}")]
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
        }
    }
}
