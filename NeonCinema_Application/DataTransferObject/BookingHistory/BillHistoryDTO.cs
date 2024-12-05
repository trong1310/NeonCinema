﻿using System;
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
		public string BillCode { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime BillDate { get; set; }
		public string Status { get; set; }
		public List<BookingHistoryDTO> Tickets { get; set; }
		public List<ComboDTO> Combos { get; set; }
	}
}
