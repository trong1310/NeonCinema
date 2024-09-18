using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.CategoryMovies;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers.Movie
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryMovieController : ControllerBase
    {
        private readonly ICategoryMovieRepositories _reps;
        private readonly IMapper _map;
        public CategoryMovieController(ICategoryMovieRepositories reps, IMapper map)
        {
            _reps = reps;
            _map = map;
        }
        [HttpGet("Getall")]
        public async Task<IActionResult> GetAll([FromQuery] CategoryDTO data, CancellationToken cancellationToken)
        {
            var obj = await _reps.GetAllMovies(data, cancellationToken);
            return Ok(obj);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryMovies data, CancellationToken cancellationToken)
        {
            var obj = await _reps.Create(_map.Map<CategoryMovies>(data),cancellationToken);
            return Ok(obj);

        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryRequest data, CancellationToken cancellationToken)
        {
            var obj = await _reps.Update(_map.Map<CategoryMovies>(data), cancellationToken);
            return Ok(obj);

        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCategoryRequest data, CancellationToken cancellationToken)
        {
            var obj = await _reps.Delete(_map.Map<CategoryMovies>(data), cancellationToken);
            return Ok(obj);

        }
    }
}
