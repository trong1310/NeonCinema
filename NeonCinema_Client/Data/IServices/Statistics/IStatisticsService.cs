﻿
using NeonCinema_Application.DataTransferObject.Statistics;
using NeonCinema_Application.DataTransferObject.User;

namespace NeonCinema_Client.Data.IServices.Statistics
{
	public interface IStatisticsService
	{
		Task<RevenueStatisticsDTO> GetRevenueStatisticsAsync(DateTime? specificDate, DateTime? startDate, DateTime? endDate);
		Task<List<ComboStatisticsDTO>> GetComboStatisticsAsync(DateTime startDate, DateTime endDate);
		Task<List<MovieStatisticsDTO>> GetMovieStatisticsAsync(DateTime startDate, DateTime endDate);
		Task<GrowthStatisticsDTO> GetGrowthStatisticsAsync(DateTime currentStart, DateTime currentEnd, DateTime previousStart, DateTime previousEnd);

		Task<List<UserDTO>> GetNewOrderCustomersAsync(DateTime startDate, DateTime endDate);
	}

}

