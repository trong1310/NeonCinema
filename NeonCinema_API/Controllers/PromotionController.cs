using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IEntityRepository<Promotion> _repos;
        private readonly IMapper _mapper;
        public PromotionController(IEntityRepository<Promotion> repos, IMapper mapper)
        {
            _mapper = mapper;
            _repos = repos;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            try
            {
                var lst = await _repos.GetAll(cancellationToken);

                if (lst == null)
                {
                    return BadRequest("Null");
                }

                return Ok(lst.Select(x => _mapper.Map<PromotionDTO>(x)).ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }       
        }

        [HttpPost("post")]
        public async Task<IActionResult> Post([FromBody] PromotionCreateRequest input, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<Promotion>(input), cancellationToken);

                if(result.IsSuccessStatusCode)
                {
                    return Ok(result.Content);
                }
                else
                {
                    return BadRequest(result.Content);
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("put")]
        public async Task<IActionResult> Put([FromBody] PromotionDTO input, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Update(_mapper.Map<Promotion>(input), cancellationToken);

                if (result.IsSuccessStatusCode)
                {
                    return Ok(result.Content);
                }
                else
                {
                    return BadRequest(result.Content);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await _repos.GetById(id, cancellationToken);

                if(entity != null)
                {
					var result = await _repos.Delete(entity, cancellationToken);

					if (result.IsSuccessStatusCode)
					{
						return Ok(result.Content);
					}
					else
					{
						return BadRequest(result.Content);
					}
				}
                
                else
                {
                    return BadRequest("Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
