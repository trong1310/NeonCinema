using MudBlazor;
using NeonCinema_Application.DataTransferObject.Genre;

namespace NeonCinema_Client.Data.IServices.Genre
{
    public interface IGenreService
    {
        Task<List<GenreDTO>> GetAllGenres(CancellationToken cancellationToken);
        Task<GenreDTO> GetGenreById(Guid id, CancellationToken cancellationToken);
        Task CreateGenre(CreateGenreRequest request, CancellationToken cancellationToken);
        Task UpdateGenre(Guid id, UpdateGenreRequest request, CancellationToken cancellationToken);
        Task DeleteGenre(Guid id, CancellationToken cancellationToken);
     
    }
}
