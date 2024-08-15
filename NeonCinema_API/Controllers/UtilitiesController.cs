using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Application.Interface.Utilities;
using Newtonsoft.Json.Linq;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilitiesController : ControllerBase
    {
        private readonly IUtilitiesRepository _reps;
        public UtilitiesController(IUtilitiesRepository reps)
        {
            _reps = reps;
            
        }
        [HttpPost("SendMail")]
        public async Task<IActionResult> SendMail([FromBody]SendMaillRequest request , string token)
        {
            var obj = await _reps.SendMail(request,token);
               return Ok(obj);
        }
        [HttpPost("Resetpass")]
        public async Task<IActionResult> ResetPassWord(ForgotPassWordRequets requets,CancellationToken cancellationToken)
        {
            var obj = await _reps.ResetPassWord(requets,cancellationToken);
            return Ok(obj);
        }
    }
}
