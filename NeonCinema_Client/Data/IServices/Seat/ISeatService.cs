using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Pagination;

namespace NeonCinema_Client.Data.IServices.Seat
{
    public interface ISeatService
    {
        Task<List<SeatDTO>> GetAllSeat();
        Task<SeatDTO> GetByIdSeat(Guid id);
        Task CreateSeat(CreateSeatDTO request);
        Task UpdateSeat(Guid id, UpdateSeatDTO request);
        Task<PaginationResponse<SeatDTO>> GetAllSeat(PaginationRequest request);

        Task<List<RoomDTO>> GetAllRooms(); 
        Task<List<SeatTypeDTO>> GetAllSeatTypes(); 
    }
}
