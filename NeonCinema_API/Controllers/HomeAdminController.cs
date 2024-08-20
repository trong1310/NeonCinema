using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Interface.Moviess;
using NeonCinema_Application.Pagination;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeAdminController : ControllerBase
    {
        private readonly IMovieRepository _repo;

        public HomeAdminController(IMovieRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllMovies([FromQuery]MovieViewRequets requets, CancellationToken cancellationToken)
        {
            var result = await _repo.GetAllMovies( requets, cancellationToken);
            
            return Ok(result);
        }
        [HttpGet("vi-du")]
        public async Task<IActionResult> Ditmetrong([FromQuery] MovieViewRequets requets, CancellationToken cancellationToken)
        {
            var result = await _repo.GetAllMovies(requets, cancellationToken);

            return Ok(result);
        }


    }
}
