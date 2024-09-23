using NeonCinema_Application.DataTransferObject.Cinemas;

namespace NeonCinema_Client.IServices.Cinemas
{
    public interface ICinemasService
    {
        public Task<List<CinemasDTO>> GetAllCinemas(CancellationToken cancellationToken);
        public Task<CinemasDTO> GetByIDRCinemas(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateCinemas(CinemasCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateCinemas(Guid id, CinemasUpdateRequest request, CancellationToken cancellationToken);
    }
}
