using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Pagination;

namespace NeonCinema_Client.Data.IServices.SeatType
{
    public interface ISeatTypeService
    {


        Task<List<SeatTypeDTO>> GetAllSeatType();
        Task<SeatTypeDTO> GetByIdSeatType(Guid id);
        Task CreateSeatType(CreateSeatTypeDTO request);
        Task UpdateSeatTYpe(Guid id, UpdateSeatTypeDTO request);

    }
}
