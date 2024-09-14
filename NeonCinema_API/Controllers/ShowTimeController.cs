using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ShowDate;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimeController : ControllerBase
    {
        IEntityRepository<ShowTime> _repos;
        IMapper _mapper;
        public ShowTimeController(IEntityRepository<ShowTime> repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-showtime")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repos.GetAll(cancellationToken);

            return Ok(result.Select(x => _mapper.Map<ShowTimeDTO>(x)).ToList());
        }

        [HttpPost("create-showtime")]
        public async Task<IActionResult> Post([FromBody] ShowTimeDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<ShowTime>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("update-showtime")]
        public async Task<IActionResult> Update([FromBody] ShowTimeUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Update(_mapper.Map<ShowTime>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("delete-showtime")]
        public async Task<IActionResult> Delete([FromBody] ShowTimeDeleteRequest requests, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Delete(_mapper.Map<ShowTime>(requests), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("get-showtime-by-id")]
        public async Task<IActionResult> GetShowTime(Guid id, CancellationToken cancellationToken)
        {
            var result = await _repos.GetById(id, cancellationToken);

            return Ok(_mapper.Map<ShowTimeDTO>(result));
        }
    }
}
