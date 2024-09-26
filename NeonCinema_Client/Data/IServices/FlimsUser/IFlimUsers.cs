using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.DataTransferObject.MovieData;

namespace NeonCinema_Client.Data.IServices.FlimsUser
{
    public interface IFlimUsers
    {
        public Task<List<MovieData>> GetMovieComing();
        public Task<PaginationResponse<MovieData>> GetMovieShowing(ViewMovieRequest request);

    }
}
