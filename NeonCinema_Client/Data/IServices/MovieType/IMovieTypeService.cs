using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.MovieTypes;

namespace NeonCinema_Client.Data.IServices.MovieType
{
    public interface IMovieTypeService
    {
        Task<List<MovieTypeDTO>> GetAllMovieType();
        Task<MovieTypeDTO> GetByIdMovieType(Guid id);
        Task CreateMovieType(CreateMovieTypeRequest request);
        Task UpdateMpvieTYpe(Guid id, UpdateMovieTypeRequest request);
    }
}
