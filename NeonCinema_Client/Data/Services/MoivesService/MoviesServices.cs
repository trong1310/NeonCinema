using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.IMoviesServices;

namespace NeonCinema_Client.Services.MoivesService
{
    public class MoviesServices : IMovieservices
    {
        private  readonly HttpClient _httpClient;
        public MoviesServices()
        {
            _httpClient = new HttpClient();
        }

        public  async Task<PaginationResponse<MovieDTO>> GetAllMovies(ViewMovieRequest request)
        {
            var obj = await _httpClient.GetFromJsonAsync<PaginationResponse<MovieDTO>>("https://localhost:7211/api/Movie/GetAll");
            return obj;
        }

    }
}
