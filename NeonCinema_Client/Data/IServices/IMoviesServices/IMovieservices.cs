using NeonCinema_Application.DataTransferObject.Movie;

namespace NeonCinema_Client.Data.IServices.IMoviesServices
{
    public interface IMovieservices
    {
        public Task<List<MovieDTO>> GetAllMovies(MovieDTO movies);
    }
}
