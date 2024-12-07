using NeonCinema_Application.DataTransferObject.BookingHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.IBookingHistory
{
	public interface IHistoryRepository
	{
		Task<List<BookingHistoryDTO>> GetBookingHistoryAsync(Guid userId);
		Task<List<BillHistoryDTO>> GetBillHistoryAsync(Guid userId);
		Task<List<BookingHistoryDTO>> GetAllBookingHistoryAsync(); // Thêm cho admin
		Task<List<BillHistoryDTO>> GetAllBillHistoryAsync(); // Thêm cho admin
	}
}
