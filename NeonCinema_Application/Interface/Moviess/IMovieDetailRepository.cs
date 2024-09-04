
using NeonCinema_Application.DataTransferObject.MovieDetail;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Moviess
{
    public interface IMovieDetailRepository
    {
        Task<HttpResponseMessage> Create(Movies movies, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Update(Movies movies, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Delete(Movies movies, CancellationToken cancellationToken);
        Task<PaginationResponse<MovieDetailDTO>> GetAllMovieDetail(MovieDetailViewRequets requets, CancellationToken cancellationToken);
    }
}
