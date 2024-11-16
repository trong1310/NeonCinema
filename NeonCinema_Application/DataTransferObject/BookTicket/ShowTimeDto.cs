using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket
{
	public class ShowTimeDto
	{
		public Guid ID { get; set; }
		public TimeSpan starTime { get; set; }
	}
}
