using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_Client.Data.IServices.Screenning
{
    public interface IScreeningService
    {
        Task<List<ScreeningDTO>> GetAllScreeningsAsync();
        Task<ScreeningDTO> GetScreeningByIdAsync(Guid id);
		Task<Screening> GetScreeningById(Guid id);
		Task<bool> CreateScreeningAsync(ScreeningCreateRequest request);
        Task<bool> UpdateScreeningAsync(Screening input);
        Task<bool> DeleteScreeningAsync(Guid id);
        Task<List<ShowTimeDTO>> GetAllShowTimesAsync();
        Task<PaginationResponse<MovieDTO>> GetAllMoviesAsync();
        Task<List<RoomDTO>> GetAllRoomsAsync();
        Task<bool> CreateSSS(SeatShowTimeStatusDTO input);
        Task<List<ShowTimeDTO>> GetShowTimebyRoomAndDate(Guid? roomId, DateTime? showDate);


    }
}
