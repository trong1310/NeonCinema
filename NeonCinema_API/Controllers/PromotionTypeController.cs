using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.PromotionTypes;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Application.Pagination;
using NeonCinema_Infrastructure.Implement.Promotions;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionTypeController : ControllerBase
    {
        private readonly IPromotionTypeRepository _repo;
        private readonly IMapper _mapper;

        public PromotionTypeController(IPromotionTypeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest paginationParams, CancellationToken cancellationToken)
        {
            var promotionTypes = await _repo.GetAllAsync(paginationParams, cancellationToken);
            return Ok(promotionTypes);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var promotionType = await _repo.GetByIdAsync(id, cancellationToken);
            if (promotionType == null) return NotFound();
            return Ok(promotionType);
        }

        [HttpPost("create-protype")]
        public async Task<IActionResult> Create(PromotionTypeCreateRequest request, CancellationToken cancellationToken)
        {
            var promotionType = await _repo.CreateAsync(request, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id = promotionType.ID }, promotionType);
        }

        [HttpPut("update-protype")]
        public async Task<IActionResult> Update(Guid id, PromotionTypeCreateRequest request, CancellationToken cancellationToken)
        {
            var promotionType = await _repo.UpdateAsync(id, request, cancellationToken);
            if (promotionType == null) return NotFound();
            return Ok(promotionType);
        }

        [HttpDelete("delete-protype")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            var deleted = await _repo.DeleteAsync(id, cancellationToken);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
