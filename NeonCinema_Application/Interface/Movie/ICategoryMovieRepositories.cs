using NeonCinema_Application.DataTransferObject.CategoryMovies;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Movie
{
    public interface ICategoryMovieRepositories
    {
        public Task<List<CategoryDTO>> GetAllMovies(CategoryDTO data, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Create(CategoryMovies data, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Update(CategoryMovies data, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Delete(CategoryMovies data, CancellationToken cancellationToken);
    }
}
