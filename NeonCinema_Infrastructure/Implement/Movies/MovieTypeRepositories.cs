using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.Interface.Movies;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Movies
{
    public class MovieTypeRepositories : IMovieTypeRepositories
    {
        public Task<HttpResponseMessage> Create(MovieType movieType, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Delete(MovieType movieType, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<MovieTypeDTO>> GetAll(MovieTypeDTO movieTypeDTO, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Update(MovieType movieType, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
