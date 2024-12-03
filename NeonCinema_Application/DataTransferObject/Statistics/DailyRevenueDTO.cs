using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Statistics
{
	public class DailyRevenueDTO
	{
		public DateTime Date { get; set; }
		public decimal Revenue { get; set; }
	}
}
