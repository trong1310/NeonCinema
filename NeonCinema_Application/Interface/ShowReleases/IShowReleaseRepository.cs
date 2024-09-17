using NeonCinema_Application.DataTransferObject.ShowRelease;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.ShowReleases
{
    public interface IShowReleaseRepository
    {
        Task<PaginationResponse<ShowReleaseDTO>> GetAllAsync(PaginationRequest request);
        Task<ShowReleaseDTO>  GetByIdAsync(Guid id);
        Task AddAsync(CreateShowReleaseDTO createDto);
        Task UpdateAsync(UpdateShowReleaseDTO updateDto);
        Task DeleteAsync(Guid id);
    }
}
