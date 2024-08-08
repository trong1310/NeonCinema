using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.PromotionTypes;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Implement.PromotionTypes;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionTypeController : ControllerBase
    {
        private readonly IPromotionTypeRepository _repository;
        private readonly IMapper _mapper;

        public PromotionTypeController(IPromotionTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet ("get-all")]
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

            var dto = _mapper.Map<PromotionTypeViewRequest>(entity);
            return Ok(dto);
        }

        [HttpPost("create-promo")]
        public async Task<IActionResult> Create([FromBody] PromotionTypeCreateRequest request, CancellationToken cancellationToken)
        {
           
            try
            {
                var entity = _mapper.Map<PromotionType>(request);
                var response = await _repository.AddAsync(entity, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {

               return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update-promo")]
        public async Task<IActionResult> Update(Guid id, [FromBody] PromotionTypeViewRequest request, CancellationToken cancellationToken)
        {
            if (id != request.PromotionTypeID)
                return BadRequest();

            var entity = await _repository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                return NotFound();

            _mapper.Map(request, entity);
            var response = await _repository.UpdateAsync(entity, cancellationToken);
            return StatusCode((int)response.StatusCode);
        }

        [HttpDelete("delete-pro")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            var response = await _repository.DeleteAsync(id, cancellationToken);
            return StatusCode((int)response.StatusCode);
        }
    }
}
