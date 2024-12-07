using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Statistics
{
	public class MovieStatisticsDTO
	{
		public Guid MovieID { get; set; }
		public string MovieName { get; set; }
		public decimal Revenue { get; set; }
		public int TicketsSold { get; set; }
	}
}
