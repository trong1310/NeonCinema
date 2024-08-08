using NeonCinema_Application.DataTransferObject.MovieDetail;
using NeonCinema_Application.DataTransferObject.MovieType;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Moviess
{
    public interface IMovieTypeRepository
    {
        Task<List<MovieTypeDTO>> GetAll(  CancellationToken cancellationToken);
        Task<HttpResponseMessage> Create(MovieType request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Update(MovieType request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Delete(MovieType request, CancellationToken cancellationToken);
    }
}
