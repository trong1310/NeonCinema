using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IMovieRepository
    {
         Task<HttpResponseMessage> CreateMovie(Movies movies,CancellationToken cancellationToken);
         Task<HttpResponseMessage> UpdateMovie(Movies movies,CancellationToken cancellationToken);
         Task<HttpResponseMessage> DeleteMovie(Movies movies, CancellationToken cancellationToken);
         Task<PaginationResponse<MovieDTO>> GetAllMovies(MovieViewRequets requets ,CancellationToken cancellationToken);
       //  Task<MovieDTO> GetById(Guid id, CancellationToken cancellationToken);

    }
}
