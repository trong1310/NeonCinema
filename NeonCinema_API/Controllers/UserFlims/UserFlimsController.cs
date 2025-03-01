﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Application.Interface.UserFlims;

namespace NeonCinema_API.Controllers.UserFlims
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFlimsController : ControllerBase
    {
        private readonly IUserMovies _reps;
        public UserFlimsController(IUserMovies reps)
        {
            
            _reps = reps;
        }
        [HttpGet("Get-coming")]
        public async Task<IActionResult> GetComing([FromQuery] ViewMovieRequest request ,CancellationToken cancellationToken)
        {
            var result = await _reps.GetMovieComingsoon(request,cancellationToken);
            return Ok(result);
        }
        [HttpGet("Get-showing")]
        public async Task<IActionResult> GetShowing([FromQuery] ViewMovieRequest request, CancellationToken cancellationToken)
        {
            var result = await _reps.GetMovieNowShowing(request,cancellationToken);
            return Ok(result);
        }
    }
}
