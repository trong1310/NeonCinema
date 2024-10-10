using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.MovieTypes;

namespace NeonCinema_Client.Data.IServices.IMovieType
{
    public interface IMovieTypeService
    {
        public Task<List<MovieTypeDTO>> GetAllMovieType(CancellationToken cancellationToken);
        public Task<MovieTypeDTO> GetMovieTypeById(Guid id, CancellationToken cancellationToken);
        public Task<MovieTypeDTO> CreateMovieType(CreateMovieTypeRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateMovieType(Guid id, UpdateMovieTypeRequest request, CancellationToken cancellationToken);
    }
}
