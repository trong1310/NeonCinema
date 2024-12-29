using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Statistics
{
	public class GrowthStatisticsDTO
	{
		public decimal CurrentRevenue { get; set; } // Doanh thu hiện tại
		public decimal PreviousRevenue { get; set; } // Doanh thu trước đó
		public double GrowthPercentage { get; set; }

	}
}
