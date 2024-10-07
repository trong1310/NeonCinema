using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Directors;

namespace NeonCinema_Client.Data.IServices.Director
{
    public interface IDirectorService
    {
        public Task<List<DirectorDTO>> GetAllDirector(CancellationToken cancellationToken);
        public Task<DirectorDTO> GetDirectorById(Guid id, CancellationToken cancellationToken);
        public Task<DirectorDTO> CreateDirector(CreateDirectorRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateDirector(Guid id, UpdateDirectorRequest request, CancellationToken cancellationToken);

    }
}
