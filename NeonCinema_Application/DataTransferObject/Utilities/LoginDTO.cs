using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Utilities
{
	public class LoginDTO
	{
		public string FullName { get; set; }
		public string Email { get; set; }
		public string RoleName { get; set; }
		public Guid ID { get; set; }
	}
}
