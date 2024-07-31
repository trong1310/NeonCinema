using NeonCinema_Application.DataTransferObject.Movie;
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
         Task<bool> CreateMovie(Movies movies,CancellationToken cancellationToken);
         Task<bool> UpdateMovie(Movies movies,CancellationToken cancellationToken);
         Task<bool> DeleteMovie(Guid id, CancellationToken cancellationToken);
         Task<List<MovieDTO>> GetAllMovies(CancellationToken cancellationToken);
         Task<MovieDTO> GetById(Guid id, CancellationToken cancellationToken);

    }
}
