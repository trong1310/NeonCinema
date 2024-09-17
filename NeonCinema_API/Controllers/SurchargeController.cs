using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.DataTransferObject.Surcharge;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurchargeController : ControllerBase
    {
        IEntityRepository<Surcharges> _repos;
        IMapper _mapper;
        public SurchargeController(IEntityRepository<Surcharges> repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-surcharge")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repos.GetAll(cancellationToken);

            return Ok(result.Select(x => _mapper.Map<SurchargeDTO>(x)).ToList());
        }

        [HttpPost("create-surcharge")]
        public async Task<IActionResult> Post([FromBody] SurchargeDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<Surcharges>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("update-surcharge")]
        public async Task<IActionResult> Update([FromBody] SurchargeUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Update(_mapper.Map<Surcharges>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("delete-surcharge")]
        public async Task<IActionResult> Delete([FromBody] SurchargeDeleteRequest requests, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Delete(_mapper.Map<Surcharges>(requests), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("get-surcharge-by-id")]
        public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
        {
            var result = await _repos.GetById(id, cancellationToken);

            return Ok(_mapper.Map<SurchargeDTO>(result));
        }
    }
}
