using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Utilities
{
    public class ReCapchaRequest
    {
        public string SiteKey { get; set; }
        public string SecretKey { get; set; }
    }
}
