using NeonCinema_Application.DataTransferObject.Cinemas;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_Client.Data.IServices.IRoom
{
    public interface IRoomService
    {
        Task<List<RoomDTO>> GetAllRooms();
        Task<HttpResponseMessage> CreateRoom(RoomCreateRequest request);
        Task<List<CinemasDTO>> GetAllCinemas();
        Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request);
        Task<RoomDTO> GetRoomById(Guid id);
        Task<List<SeatDTO>> GetSeatsByRoomId(Guid roomId);
        
    }
}
