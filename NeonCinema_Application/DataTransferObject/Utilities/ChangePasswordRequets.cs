
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Utilities
{
    public class ChangePasswordRequets
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string NewPassWord { get; set; }
        public string ConfirmNewPassWord { get; set; }
    }
}
