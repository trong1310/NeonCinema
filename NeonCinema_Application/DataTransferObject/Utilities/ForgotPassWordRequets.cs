using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Utilities
{
    public class ForgotPassWordRequets
    {
        public Guid Id { get; set; }
        public string Email {  get; set; } 
        public string PassWord { get; set; }
        public string ConfirmPassWord { get; set; }

          
    }
}
