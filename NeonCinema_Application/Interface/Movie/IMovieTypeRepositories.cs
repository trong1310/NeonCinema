
using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Movie
{
    public interface IMovieTypeRepositories
    {
        public Task<List<MovieTypeDTO>> GetAllMovieType();
        public Task<MovieTypeDTO> GetMovieTypeById(Guid id, CancellationToken cancellationToken);
        public Task<MovieTypeDTO> CreateMovieType(CreateMovieTypeRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateMovieType(Guid id, UpdateMovieTypeRequest request, CancellationToken cancellationToken);

    }
}
