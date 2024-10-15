using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.DataTransferObject.Language;

namespace NeonCinema_Client.Data.IServices.Director
{
    public interface IDirectorService
    {
        Task<List<DirectorDTO>> GetAllDirector();
        Task<DirectorDTO> GetByIdDirector(Guid id);
        Task CreateDirector(CreateDirectorRequest request);
        Task UpdateDirector(Guid id, UpdateDirectorRequest request);
    }
}
