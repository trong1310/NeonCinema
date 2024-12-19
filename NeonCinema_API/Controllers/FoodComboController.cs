using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.FoodCombos;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Implement.FoodCombo_R;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodComboController : ControllerBase
    {
        FoodComboRepository _repos;
        IMapper _mapper;
        public FoodComboController(FoodComboRepository repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-foodcombo")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repos.GetAll(cancellationToken);

            return Ok(result);
        }

        [HttpPost("create-foodcombo")]
        public async Task<IActionResult> Post([FromBody] FoodComboCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.CreateFoodCombo(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("update-foodcombo")]
        public async Task<IActionResult> Update([FromBody] FoodComboUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.UpdateCombo(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpDelete("delete-foodcombo")]
        //public async Task<IActionResult> Delete([FromBody] FoodComboDeleteRequest requests, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        var result = await _repos.Delete(_mapper.Map<FoodCombo>(requests), cancellationToken);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        [HttpGet("get-foodcombo-by-id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _repos.DetailCombo(id);

            return Ok(result);
        }
    }
}
