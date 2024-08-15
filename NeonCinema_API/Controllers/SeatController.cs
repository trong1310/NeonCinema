using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        IMapper _mapper;
        ISeatRepository _repos;

        public SeatController(IMapper mapper, ISeatRepository repos)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-seat")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _repos.GetAll(cancellationToken);

            return Ok(lst);
        }

        [HttpGet("get-seat")]
        public async Task<IActionResult> Get(Guid id, Guid roomid, CancellationToken cancellationToken)
        {
            var lst = await _repos.GetById(id, roomid, cancellationToken);

            return Ok(lst);
        }

        [HttpPost("post-seat")]
        public async Task<IActionResult> Create([FromBody] SeatDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<Seat>(request), cancellationToken);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update-seat")]
        public async Task<IActionResult> Update([FromBody] SeatDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Update(_mapper.Map<Seat>(request), cancellationToken);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete-seat")]
        public async Task<IActionResult> Delete([FromBody] SeatDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Delete(_mapper.Map<Seat>(request), cancellationToken);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
