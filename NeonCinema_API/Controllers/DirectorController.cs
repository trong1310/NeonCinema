using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Application.Interface.Directors;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorRepositories _reps;
        private readonly IMapper _maps;
        public DirectorController(IDirectorRepositories reps, IMapper maps)
        {
            _maps = maps;
            _reps = reps;
        }
        [HttpGet("Get-All")]
        public async Task<IActionResult> GetAll([FromQuery] ViewDirectorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _reps.GetAllDirector(request, cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex) 
            {
                return Content(ex.Message);
            }
        
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateDirectorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _reps.CreateDirector(_maps.Map<Director>(request),cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateDirectorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _reps.UpdateDirector(_maps.Map<Director>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteDirectorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _reps.DeleteDirector(_maps.Map<Director>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
