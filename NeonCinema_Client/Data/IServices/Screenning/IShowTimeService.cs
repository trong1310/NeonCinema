using NeonCinema_Application.DataTransferObject.ShowTime;

namespace NeonCinema_Client.Data.IServices.Screenning
{
    public interface IShowTimeService
    {
        Task<List<ShowTimeDTO>> GetAllShowTimes(CancellationToken cancellationToken);
        Task<ShowTimeDTO> GetShowTimeById(Guid id, CancellationToken cancellationToken);
        Task CreateShowTime(ShowTimeCreateRequest request, CancellationToken cancellationToken);
        Task UpdateShowTime(Guid id, ShowTimeUpdateRequest request, CancellationToken cancellationToken);
        Task DeleteShowTime(Guid id, CancellationToken cancellationToken);
    }
}
