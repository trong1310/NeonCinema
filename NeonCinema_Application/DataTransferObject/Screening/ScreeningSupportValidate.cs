using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
	public class ScreeningSupportValidate
	{
		public Guid ID { get; set; }
		public ScreeningStatus Status { get; set; }
		public Guid ShowTimeID { get; set; }
		public DateTime ShowDate { get; set; }
		public Guid RoomID { get; set; }
	}
}
