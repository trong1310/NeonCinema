using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_API.Controllers.PromotionController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {

        private readonly IPromotionRepository _repository;
        private readonly IMapper _mapper;

        public PromotionController(IPromotionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(request, cancellationToken);
            return Ok(result);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                return NotFound();

            var dto = _mapper.Map<PromotionViewRequest>(entity);
            return Ok(dto);
        }

        [HttpPost("create-promotion")]
        public async Task<IActionResult> Create([FromBody] CreatePromotionRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Promotion>(request);
            var response = await _repository.AddAsync(entity, cancellationToken);
            return StatusCode((int)response.StatusCode);
        }

        [HttpPut("Update-promotion")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdatePromotionRequest request, CancellationToken cancellationToken)
        {
            if (id != request.PromotionID)
                return BadRequest();

            var entity = await _repository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                return NotFound();

            _mapper.Map(request, entity);
            var response = await _repository.UpdateAsync(entity, cancellationToken);
            return StatusCode((int)response.StatusCode);
        }

        [HttpDelete("Delete-promo")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            var response = await _repository.DeleteAsync(id, cancellationToken);
            return StatusCode((int)response.StatusCode);
        }
    }

}

