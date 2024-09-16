using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Checkins;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckinController : ControllerBase
    {
        IEntityRepository<Checkin> _repos;
        IMapper _mapper;
        public CheckinController(IEntityRepository<Checkin> repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-Checkin")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repos.GetAll(cancellationToken);

            return Ok(result.Select(x => _mapper.Map<CheckinDTO>(x)).ToList());
        }

        [HttpPost("create-Checkin")]
        public async Task<IActionResult> Post([FromBody] CheckinDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<Checkin>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("update-Checkin")]
        public async Task<IActionResult> Update([FromBody] CheckinUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Update(_mapper.Map<Checkin>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("delete-Checkin")]
        public async Task<IActionResult> Delete([FromBody] CheckinDeleteRequest requests, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Delete(_mapper.Map<Checkin>(requests), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("get-Checkin-by-id")]
        public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
        {
            var result = await _repos.GetById(id, cancellationToken);

            return Ok(_mapper.Map<CheckinDTO>(result));
        }
    }
}
