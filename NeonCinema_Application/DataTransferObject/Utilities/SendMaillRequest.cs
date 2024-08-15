using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Utilities
{
    public class SendMaillRequest
    {
        public  Guid Id { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
