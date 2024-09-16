using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        IEntityRepository<Bill> _repos;
        IMapper _mapper;
        public BillController(IEntityRepository<Bill> repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-bill")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repos.GetAll(cancellationToken);

            return Ok(result.Select(x => _mapper.Map<BillDTO>(x)).ToList());
        }

        [HttpPost("create-bill")]
        public async Task<IActionResult> Post([FromBody] BillDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<Bill>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("update-bill")]
        public async Task<IActionResult> Update([FromBody] BillUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Update(_mapper.Map<Bill>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("delete-bill")]
        public async Task<IActionResult> Delete([FromBody] BillDeleteRequest requests, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Delete(_mapper.Map<Bill>(requests), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("get-bill-by-id")]
        public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
        {
            var result = await _repos.GetById(id, cancellationToken);

            return Ok(_mapper.Map<BillDTO>(result));
        }
    }
}
