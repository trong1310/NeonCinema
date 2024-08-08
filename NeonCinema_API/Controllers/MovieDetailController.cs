using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.MovieDetail;
using NeonCinema_Application.Interface.Moviess;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieDetailController : ControllerBase
    {
        private readonly IMovieDetailRepository _reps;
        private readonly IMapper _mapper;
        public MovieDetailController(IMovieDetailRepository reps, IMapper mapper)
        {
            _mapper = mapper;
            _reps = reps;
        }
        [HttpGet("Get-MovieDetail")]
        public async Task<IActionResult> GetAll([FromQuery] MovieDetailViewRequets requets , CancellationToken cancellationToken)
        {
            var result = await _reps.GetAllMovieDetail(requets, cancellationToken);
            return Ok(result);
        }
        [HttpPost("Create-MovieDetail")]
        public async Task<IActionResult> Create([FromBody]MovieDetailCreateRequets createRequets , CancellationToken cancellationToken)
        {
            var result = await _reps.Create(_mapper.Map<MovieDetail>(createRequets),cancellationToken);
            return Ok(result);
        }
        [HttpPut("Update-MovieDetail")]
        public async Task<IActionResult> Update([FromBody] MovieDetailUpdateRequets updateRequets , CancellationToken cancellationToken)
        {
            var result = await _reps.Update(_mapper.Map<MovieDetail>(updateRequets), cancellationToken);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] MovieDetailDeleteRequets deleteRequets , CancellationToken cancellationToken)
        {
            var result = await _reps.Delete(_mapper.Map<MovieDetail>(deleteRequets), cancellationToken);
            return Ok(result);
        }

    }
}
