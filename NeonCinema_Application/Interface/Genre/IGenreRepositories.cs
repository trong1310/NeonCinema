using NeonCinema_Application.DataTransferObject.Genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Genre
{
    public interface IGenreRepositories
    {
        Task<List<GenreDTO>> GetAllGenres(CancellationToken cancellationToken);
        Task<GenreDTO> GetGenreById(Guid id, CancellationToken cancellationToken);
        Task CreateGenre(CreateGenreRequest request, CancellationToken cancellationToken);
        Task UpdateGenre(Guid id, UpdateGenreRequest request, CancellationToken cancellationToken);
        Task DeleteGenre(Guid id, CancellationToken cancellationToken);
    }
}
