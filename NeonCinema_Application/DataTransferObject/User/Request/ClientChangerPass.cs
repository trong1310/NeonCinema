using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.User.Request
{
    public class ClientChangerPass
    {
        public string Currenpassword {  get; set; }
        public string Newpassword { get; set; }
       public string Confirmpasss { get; set; }
    }
}
