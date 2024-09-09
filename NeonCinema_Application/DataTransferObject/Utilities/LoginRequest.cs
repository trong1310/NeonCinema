using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Utilities
{
	public class LoginRequest
	{
		
		public string EmailOrPhone { get; set; }
		public string Password { get; set; }
		
	}
}
