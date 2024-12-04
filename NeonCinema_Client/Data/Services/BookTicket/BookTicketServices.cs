﻿using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ActorMovies;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
using NeonCinema_Application.DataTransferObject.FoodCombos;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Enum;
using System.Net.Http.Json;
using System.Threading;

namespace NeonCinema_Client.Data.Services.BookTicket
{
	public class BookTicketServices
    {
        private readonly HttpClient _httpClient;
        public BookTicketServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<MovieDTO>> MoviesNowShowing()
        {
            try
            {
                var results = await _httpClient.GetFromJsonAsync<List<MovieDTO>>($"https://localhost:7211/api/Movie/GetNowShowing");
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception("co loi xay ra : " + ex.Message);
            }
        }
		public async Task<List<MovieDTO>> MoviesComing()
		{
			try
			{
				var results = await _httpClient.GetFromJsonAsync<List<MovieDTO>>($"https://localhost:7211/api/Movie/GetComing");
				return results;
			}
			catch (Exception ex)
			{
				throw new Exception("co loi xay ra : " + ex.Message);
			}
		}
		public async Task<List<ActorMoviesDto>> GetActorsByFilmAsync(Guid moviesId, CancellationToken cancellationToken)
		{
			var respones = await _httpClient.GetFromJsonAsync<List<ActorMoviesDto>>($"https://localhost:7211/api/Actor/get-actor-byflims?movieID={moviesId}");
			return respones;
		}
		public async Task<List<ScreeningMoviesDto>> GetScreeningMovies(Guid MovieId, DateTime? showdate)
		{
			try
			{
				string formattedDate = showdate?.ToString("yyyy-MM-dd");
				var results = await _httpClient.GetFromJsonAsync<List<ScreeningMoviesDto>>($"https://localhost:7211/api/BookTicket/screening?movieId={MovieId}&showDate={formattedDate}");
				return results;
			}
			catch (Exception ex)
			{
				throw new Exception("co loi xay ra : " + ex.Message);
			}
		}
		public async Task<ScreeningMoviesDto> ChooseScrening(Guid id)
		{
			try
			{
				var results = await _httpClient.GetFromJsonAsync<ScreeningMoviesDto>($"https://localhost:7211/api/BookTicket/choose-screning?id={id}");
				return results;
			}
			catch (Exception ex)
			{
				throw new Exception("co loi xay ra : " + ex.Message);
			}
		}
		public async Task<List<FoodComboDTO>> GetFoodCombo()
        {
            try
            {
                var results = await _httpClient.GetFromJsonAsync<List<FoodComboDTO>>($"https://localhost:7211/api/FoodCombo/get-all-foodcombo");
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception("co loi xay ra : " + ex.Message);
            }
		}
		public Task<HttpResponseMessage> BookTicket(CreateBookTicketRequest request, CancellationToken cancellationToken)
		{
			try
			{
				var results = _httpClient.PostAsJsonAsync($"https://localhost:7211/api/BookTicket/book-ticket",request,cancellationToken);
				return results;
			}
			catch (Exception ex)
			{
				throw new Exception("co loi xay ra : " + ex.Message);
			}
		}
		public async Task<HttpResponseMessage> UpdateStateSeats(Guid seatId, seatEnum status)
		{
			try
			{
				var seatUpdateData = new
				{
					SeatId = seatId,
					Status = status
				};

				var results = await _httpClient.PutAsJsonAsync("https://localhost:7211/api/BookTicket/UpdateSeatStatus", seatUpdateData);
				return results;
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra: " + ex.Message);
			}
		}

		public async Task<RankMemberResp> SeachAccount(string? phoneNumber)
		{
			try
			{
				var respones = await _httpClient.GetFromJsonAsync<RankMemberResp>($"https://localhost:7211/api/BookTicket/account/{phoneNumber}");
				return respones;
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra: " + ex.Message);
			}
		}
	}
}
