using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;

namespace NeonCinema_Client.Data.IServices.IMoviesServices
{
    public interface IMovieservices
    {
        public Task<List<MovieDTO>> GetAllMovies();
        public Task<List<MovieDTO>> FilMovie(List<MovieDTO> lst,
			Func<MovieDTO, bool> dk1 = null,
			Func<MovieDTO, bool> dk2 = null,
			Func<MovieDTO, bool> dk3 = null,
			Func<MovieDTO, bool> dk4 = null);
    }
}
