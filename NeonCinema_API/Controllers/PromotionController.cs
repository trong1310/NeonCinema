using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.Interface;
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
        private readonly IPromotionRepository _repo;
        private readonly IMapper _mapper;

        public PromotionController(IPromotionRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("get-all-promotion")]
        public async Task<IActionResult> GetAllPromotions(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var promotions = await _repo.GetAllPromotionsAsync(id, cancellationToken);
                return Ok(promotions);
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetPromotionById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var promotion = await _repo.GetPromotionByIdAsync(id, cancellationToken);
                if (promotion == null)
                {
                    return NotFound("Promotion not found");
                }
                return Ok(promotion);
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreatePromotion([FromBody] CreatePromotionRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var promotion = _mapper.Map<Promotion>(request);
                var result = await _repo.AddPromotionAsync(promotion, cancellationToken);
                if (result)
                {
                    return CreatedAtAction(nameof(GetPromotionById), new { id = promotion.PromotionID }, promotion);
                }
                return BadRequest("Unable to create promotion");
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdatePromotion([FromBody] UpdatePromotionRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var promotion = _mapper.Map<Promotion>(request);
                var result = await _repo.UpdatePromotionAsync(promotion, cancellationToken);
                if (result)
                {
                    return Ok("Promotion updated successfully");
                }
                return NotFound("Promotion not found");
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeletePromotion(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repo.DeletePromotionAsync(id, cancellationToken);
                if (result)
                {
                    return Ok("Promotion deleted successfully");
                }
                return NotFound("Promotion not found");
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}
