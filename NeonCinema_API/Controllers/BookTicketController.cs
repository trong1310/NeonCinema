using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.Configuration;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTicketController : ControllerBase
    {
        IEntityRepository<BookTickets> _repos;
        IMapper _mapper;
        public BookTicketController(IEntityRepository<BookTickets> repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-bookticket")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repos.GetAll(cancellationToken);

            return Ok(result.Select(x => _mapper.Map<BookTicketDTO>(x)).ToList());
        }

        [HttpPost("create-bookticket")]
        public async Task<IActionResult> Post([FromBody] BookTicketDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<BookTickets>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("update-bookticket")]
        public async Task<IActionResult> Update([FromBody] BookTicketUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Update(_mapper.Map<BookTickets>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("delete-bookticket")]
        public async Task<IActionResult> Delete([FromBody] BookTicketDeleteRequest requests, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Delete(_mapper.Map<BookTickets>(requests), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("get-bookticket-by-id")]
        public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
        {
            var result = await _repos.GetById(id, cancellationToken);

            return Ok(_mapper.Map<BookTicketDTO>(result));
        }
    }
}
