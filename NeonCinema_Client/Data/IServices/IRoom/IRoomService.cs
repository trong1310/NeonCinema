using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;

namespace NeonCinema_Client.Data.IServices.IRoom
{
    public interface IRoomService
    {
        Task<List<RoomDTO>> GetAllRooms(CancellationToken cancellationToken);
        Task<RoomDTO> GetRoomById(Guid id, CancellationToken cancellationToken);
        Task<HttpResponseMessage> CreateRoom(RoomCreateRequest request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken);
        Task<List<SeatDTO>> GetSeats();
    }
}
