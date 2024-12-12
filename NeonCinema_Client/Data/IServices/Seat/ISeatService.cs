using NeonCinema_Application.DataTransferObject.Cinemas;
using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_Client.Data.IServices.Seat
{
    public interface ISeatService
    {

        public Task<PaginationResponse<SeatDTO>> GetAllSeat(ViewSeatRequest request);
        
        public Task<List<SeatTypeDTO>> GetAllSeatType();
        Task<List<RoomDTO>> GetAllRooms();
        public Task<HttpResponseMessage> CreateSeat(CreateSeatDTO request);
        public Task<HttpResponseMessage> UpdateSeate(Guid id, UpdateSeatDTO request);
        public Task<SeatDTO> GetSeatById(Guid id);
        Task<List<SeatDTO>> GetAllSeats(CancellationToken cancellationToken);
        

    }
}
