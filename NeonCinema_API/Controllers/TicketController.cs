﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository _repos;
        private readonly IMapper _mapper;

        public TicketController(ITicketRepository repos, IMapper mapper)
        {
            _mapper = mapper;
            _repos = repos;
        }

        [HttpPost("create-ticket")]

        public async Task<IActionResult> PostTicket([FromBody] TicketDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.CreateTicket(_mapper.Map<TicketPrice>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("update-ticket")]
        public async Task<IActionResult> UpdateTicket([FromBody] TicketUpdateRequests request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.UpdateTicket(_mapper.Map<TicketPrice>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("delete-ticket")]
        public async Task<IActionResult> DeleteTicket([FromBody] TicketDeleteRequests requests, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.DeleteTicket(_mapper.Map<TicketPrice>(requests), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
