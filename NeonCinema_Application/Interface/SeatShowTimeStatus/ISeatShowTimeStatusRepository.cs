using NeonCinema_Application.DataTransferObject.SeatShowTimeStatus;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.SeatShowTimeStatus
{
    public interface ISeatShowTimeStatusRepository
    {
        Task<PaginationResponse<SeatShowTimeStatusDTO>> GetAllAsync(PaginationRequest request);
        Task<SeatShowTimeStatusDTO> GetByIdAsync(Guid id);
        Task AddAsync(CreateSeatShowTimeStatusDTO seatShowTimeStatus);
        Task UpdateAsync(UpdateSeatShowTimeStatusDTO seatShowTimeStatus);
        Task DeleteAsync(Guid id);
    }
}
