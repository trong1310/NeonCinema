using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookingHistory
{
	public class BillHistoryDTO
	{
		public Guid BillID { get; set; }
		public string UserName { get; set; }
		public Guid? StaffID { get; set; } // ID nhân viên phụ trách
		public string StaffName { get; set; } // Tên nhân viên phụ trách
		public long BillCode { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime BillDate { get; set; }

		public string Status { get; set; }

		// Thông tin bổ sung
		public string TheaterName = "NeonCinemas";
		public string TheaterAddress = "Số 1 - Phúc diễn - Bắc từ liêm - Hà nội";
		public List<BookingHistoryDTO> Tickets { get; set; }
		public List<ComboDTO> Combos { get; set; }
	}
}
