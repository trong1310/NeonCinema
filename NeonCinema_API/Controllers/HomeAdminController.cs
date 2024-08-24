using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using NeonCinema_Application.DataTransferObject.MovieDetail;
using NeonCinema_Application.Interface.Moviess;
using NeonCinema_Application.Pagination;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeAdminController : ControllerBase
    {
        private readonly IMovieDetailRepository _repo;

        public HomeAdminController(IMovieDetailRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllMovies([FromQuery]MovieDetailViewRequets requets, CancellationToken cancellationToken)
        {
            var result = await _repo.GetAllMovieDetail( requets, cancellationToken);
            
            return Ok(result);
        }
        


    }
}
