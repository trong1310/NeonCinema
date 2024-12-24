using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket.Request
{
	public class CreateBookTicketRequest
	{
		public Guid? CreateBy {get; set;}
		public Guid? MovieId { get; set; }
		public Guid? ScreeningID { get; set; }
		public Guid? AccountID { get; set; }
		public double? Point { get; set; }
		public Guid? Voucher { get; set; }
		public List<Guid>? SeatID { get; set; }
		public List<BillComboReuqest>? BillCombos { get; set; }
	}
}
