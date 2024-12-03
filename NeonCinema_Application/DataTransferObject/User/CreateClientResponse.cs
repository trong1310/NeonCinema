using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.User
{
    public class CreateClientResponse
    {
        public HttpResponseMessage HttpResponse { get; set; }
        public string GeneratedPassword { get; set; }
    }
}
