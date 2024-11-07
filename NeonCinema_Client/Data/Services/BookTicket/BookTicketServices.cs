using NeonCinema_Application.DataTransferObject.ActorMovies;
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
				var results = await _httpClient.GetFromJsonAsync<List<MovieDTO>>($"https://localhost:7211/api/Movie/GetNowShowing");
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
	}
}
