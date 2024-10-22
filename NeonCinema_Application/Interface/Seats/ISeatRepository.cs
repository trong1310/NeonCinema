using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Seats
{
    public interface ISeatRepository
    {
        public Task<PaginationResponse<SeatDTO>> GetAllAsync(ViewSeatRequest request, CancellationToken cancellationToken);
        public Task<SeatDTO> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> AddAsync(CreateSeatDTO request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateAsync(Seat request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteAsync(Seat request, CancellationToken cancellationToken);
        
        

    }
}
