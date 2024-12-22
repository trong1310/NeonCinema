using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.DataTransferObject.MovieData;

namespace NeonCinema_Client.Data.IServices.FlimsUser
{
    public interface IFlimUsers
    {
        public Task<List<MovieData>> GetMovieComing();
        public Task<List<MovieData>> GetStopShowing();
        public Task<PaginationResponse<MovieDTO>> GetMovieShowing(ViewMovieRequest request);

    }
}
