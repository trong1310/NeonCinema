using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ActorMovies;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.FoodCombos;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;

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
		public async Task<ScreeningMoviesDto> GetScreeningMovies(Guid MovieId)
		{
			try
			{
				var results = await _httpClient.GetFromJsonAsync<ScreeningMoviesDto>($"https://localhost:7211/api/BookTicket/ScreeningByflims?moviesID={MovieId}");
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
				var results = _httpClient.PostAsJsonAsync($"https://localhost:7211/api/BookTicket/Bookticket",request,cancellationToken);
				return results;
			}
			catch (Exception ex)
			{
				throw new Exception("co loi xay ra : " + ex.Message);
			}
		}

	}
}
