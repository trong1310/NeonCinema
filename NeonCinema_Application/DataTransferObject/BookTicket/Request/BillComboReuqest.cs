using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket.Request
{
	public class BillComboReuqest
	{
		public Guid FoodComboId { get; set; }
		public int Quantity { get; set; }
	}
}
