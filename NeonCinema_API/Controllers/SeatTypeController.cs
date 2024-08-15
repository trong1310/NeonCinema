using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatTypeController : ControllerBase
    {
        IMapper _mapper;
        ISeatTypeRepository _repos;

        public SeatTypeController(IMapper mapper, ISeatTypeRepository repos)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-seatT")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _repos.GetAll(cancellationToken);

            return Ok(lst);
        }

        [HttpGet("get-seatT")]
        public async Task<IActionResult> Get(Guid id, Guid roomid, CancellationToken cancellationToken)
        {
            var lst = await _repos.GetById(id, cancellationToken);

            return Ok(lst);
        }

        [HttpPost("post-seatT")]
        public async Task<IActionResult> Create([FromBody] SeatTypeDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<SeatType>(request), cancellationToken);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update-seatT")]
        public async Task<IActionResult> Update([FromBody] SeatTypeDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Update(_mapper.Map<SeatType>(request), cancellationToken);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete-seatT")]
        public async Task<IActionResult> Delete([FromBody] SeatTypeDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Delete(_mapper.Map<SeatType>(request), cancellationToken);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
