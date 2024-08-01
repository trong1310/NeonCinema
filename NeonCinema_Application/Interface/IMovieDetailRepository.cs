using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.MovieDetail;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IMovieDetailRepository
    {
        Task<HttpResponseMessage> Create(MovieDetail movies, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Update(MovieDetail movies, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Delete(MovieDetail movies, CancellationToken cancellationToken);
        Task<PaginationResponse<MovieDTO>> GetAllMovieDetail(MovieDetailViewRequets requets, CancellationToken cancellationToken);
    }
}
