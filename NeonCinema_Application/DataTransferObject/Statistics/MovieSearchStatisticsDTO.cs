using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Statistics
{
	public class MovieSearchStatisticsDTO
	{
		public string MovieName { get; set; }
		public int TicketsSold { get; set; }
		public decimal TotalRevenue { get; set; }
	}
}
