using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.SeenMail
{
    public class MailResp
    {
        public static string _URL = string.Empty;   
        public static void Init(string url)
        {
            _URL = url;
        }

    }
}
