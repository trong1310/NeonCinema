using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;

namespace NeonCinema_Client.Data.IServices.IMoviesServices
{
    public interface IMovieservices
    {
        public Task<PaginationResponse<MovieDTO>> GetAllMovies(ViewMovieRequest request);
    }
}
