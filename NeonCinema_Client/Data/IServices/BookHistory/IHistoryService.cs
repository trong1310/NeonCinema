using NeonCinema_Application.DataTransferObject.BookingHistory;

namespace NeonCinema_Client.Data.IServices.BookHistory
{
	public interface IHistoryService
	{
		Task<List<BookingHistoryDTO>> GetBookingHistoryAsync(Guid userId);
		Task<List<BillHistoryDTO>> GetBillHistoryAsync(Guid userId);
		Task<List<BookingHistoryDTO>> GetAllBookingHistoryAsync(); // Thêm cho admin
		Task<List<BillHistoryDTO>> GetAllBillHistoryAsync(); // Thêm cho admin
	}
}
