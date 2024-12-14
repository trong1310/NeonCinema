using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.User.Request
{
	public class UpdateStateAccountRequestModels
	{
		public Guid Id { get; set; }
		
		public EntityStatus State { get; set; }
	}
}
