using NeonCinema_Application.DataTransferObject.BookingHistory;
using NeonCinema_Client.Data.IServices.BookHistory;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_Client.Data.Services.BookHistory
{
	public class HistoryService : IHistoryService
	{
		private readonly HttpClient _httpClient;

		public HistoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<BookingHistoryDTO>> GetBookingHistoryAsync(Guid userId)
		{
			try
			{
				var response = await _httpClient.GetFromJsonAsync<List<BookingHistoryDTO>>($"api/History/bookings/{userId}");
				return response ?? new List<BookingHistoryDTO>();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching booking history: {ex.Message}");
				return new List<BookingHistoryDTO>();
			}
		}

		public async Task<List<BillHistoryDTO>> GetBillHistoryAsync(Guid userId)
		{
			try
			{
				var response = await _httpClient.GetFromJsonAsync<List<BillHistoryDTO>>($"api/History/bills/{userId}");
				return response ?? new List<BillHistoryDTO>();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching bill history: {ex.Message}");
				return new List<BillHistoryDTO>();
			}
		}

		public async Task<List<BookingHistoryDTO>> GetAllBookingHistoryAsync()
		{
			try
			{
				var response = await _httpClient.GetFromJsonAsync<List<BookingHistoryDTO>>($"api/History/admin/bookings");
				return response ?? new List<BookingHistoryDTO>();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching booking history: {ex.Message}");
				return new List<BookingHistoryDTO>();
			}
		}

		public async Task<List<BillHistoryDTO>> GetAllBillHistoryAsync()
		{
			try
			{
				var response = await _httpClient.GetFromJsonAsync<List<BillHistoryDTO>>($"api/History/admin/bills");
				return response ?? new List<BillHistoryDTO>();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching bill history: {ex.Message}");
				return new List<BillHistoryDTO>();
			}
		}
	}
}
