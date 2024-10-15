using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.ShowTime;

namespace NeonCinema_Client.Data.IServices.Screenning
{
    public interface IScreeningService
    {
        Task<List<ScreeningDTO>> GetAllScreenings(CancellationToken cancellationToken);
        Task<ScreeningDTO> GetScreeningById(Guid id, CancellationToken cancellationToken);
        Task<HttpResponseMessage> CreateScreening(ScreeningCreateRequest request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateScreening(Guid id,ScreeningUpdateRequest request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteScreening(Guid id, CancellationToken cancellationToken);
        Task<List<MovieDTO>> GetAllMovies(CancellationToken cancellationToken);
        Task<List<ShowTimeDTO>> GetAllShowTimes(CancellationToken cancellationToken);
        Task<List<RoomDTO>> GetAllRooms(CancellationToken cancellationToken);

    }
}
