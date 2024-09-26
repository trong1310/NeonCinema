using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;

namespace NeonCinema_Client.DataTransferObject.MovieData
{
    public class ViewMovieRequestB : PaginationRequest
    {

        public List<MovieDTO> Movies { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
