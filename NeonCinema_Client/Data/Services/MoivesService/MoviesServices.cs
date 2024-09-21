using NeonCinema_Application.DataTransferObject.Movie;
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

        public Task<List<MovieDTO>> GetAllMovies(MovieDTO movies)
        {
            throw new NotImplementedException();
        }

    }
}
