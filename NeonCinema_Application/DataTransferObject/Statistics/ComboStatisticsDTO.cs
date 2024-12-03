using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Statistics
{
	public class ComboStatisticsDTO
	{

		public Guid ComboID { get; set; }
		public string ComboName { get; set; }
		public int QuantitySold { get; set; }
	}
}
