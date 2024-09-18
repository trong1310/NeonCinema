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
        public Task<List<MovieTypeDTO>> GetAll(MovieTypeDTO movieTypeDTO, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Create(MovieType movieType, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Update(MovieType movieType, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Delete(MovieType movieType, CancellationToken cancellationToken);
    }
}
