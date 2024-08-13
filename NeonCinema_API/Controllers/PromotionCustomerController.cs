using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.PromotionCustomers;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionCustomerController : ControllerBase
    {
        private readonly IPromotionCustomerRepository _repository;
        private readonly IMapper _mapper;

        public PromotionCustomerController(IPromotionCustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(request, cancellationToken);
            return Ok(result);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid promotionId, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(promotionId, cancellationToken);
            if (entity == null)
                return NotFound();

            var dto = _mapper.Map<PromotionCustomerViewRequest>(entity);
            return Ok(dto);
        }

        [HttpPost("Create-pro")]
        public async Task<IActionResult> Create([FromBody] CreatePromotionCustomerRequest  request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<PromotionCustomer>(request);
            var response = await _repository.AddAsync(entity, cancellationToken);
            return StatusCode((int)response.StatusCode);
        }

        [HttpPut("Update-pro")]
        public async Task<IActionResult> Update(Guid promotionId, Guid customerId, [FromBody] UpdatePromotionCustomerRequest request, CancellationToken cancellationToken)
        {
            if (promotionId != request.PromotionId || customerId != request.ID)
                return BadRequest();

            var entity = await _repository.GetByIdAsync(promotionId, cancellationToken);
            if (entity == null)
                return NotFound();

            _mapper.Map(request, entity);
            var response = await _repository.UpdateAsync(entity, cancellationToken);
            return StatusCode((int)response.StatusCode);
        }

        [HttpDelete("Delete-pro")]
        public async Task<IActionResult> Delete(Guid promotionId, Guid customerId, CancellationToken cancellationToken)
        {
            var response = await _repository.DeleteAsync(promotionId, customerId, cancellationToken);
            return StatusCode((int)response.StatusCode);
        }
    }
}
