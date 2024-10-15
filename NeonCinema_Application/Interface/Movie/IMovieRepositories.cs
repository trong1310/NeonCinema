using Microsoft.AspNetCore.Http;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Movie
{
    public interface IMovieRepositories
    {
        public Task<PaginationResponse<MovieDTO>> GetAll(ViewMovieRequest request,CancellationToken cancellationToken);
        public  Task<MovieDTO> GetById(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Create (CreateMovieRequest request,CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Update (Movies request,CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Delete (Movies request,CancellationToken cancellationToken);
    }
}
