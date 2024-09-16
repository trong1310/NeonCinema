using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.ShowRelease;
using NeonCinema_Application.Interface.ShowReleases;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Show_release
{
    public class ShowReleaseRepository : IShowReleaseRepository
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;

        public ShowReleaseRepository(NeonCinemasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Get all with pagination
        public async Task<PaginationResponse<ShowReleaseDTO>> GetAllAsync(PaginationRequest request)
        {
            var totalRecords = await _context.Show_release.CountAsync();
            var data = await _context.Show_release
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            bool hasNext = (request.PageNumber * request.PageSize) < totalRecords;

            var mappedData = _mapper.Map<List<ShowReleaseDTO>>(data); // Map entities to DTO

            return new PaginationResponse<ShowReleaseDTO>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = hasNext,
                Data = mappedData
            };
        }

        // Get by ID
        public async Task<ShowReleaseDTO> GetByIdAsync(Guid id)
        {
            var showRelease = await _context.Show_release.FindAsync(id);
            return _mapper.Map<ShowReleaseDTO>(showRelease); // Map entity to DTO
        }

        // Add a new ShowRelease
        public async Task AddAsync(CreateShowReleaseDTO createDto)
        {
            var showRelease = _mapper.Map<NeonCinema_Domain.Database.Entities.Show_release>(createDto); // Map DTO to entity
            await _context.Show_release.AddAsync(showRelease);
            await _context.SaveChangesAsync();
        }

        // Update an existing ShowRelease
        public async Task UpdateAsync(UpdateShowReleaseDTO updateDto)
        {
            var existingShowRelease = await _context.Show_release.FindAsync(updateDto.ID);
            if (existingShowRelease != null)
            {
                _mapper.Map(updateDto, existingShowRelease); // Map update DTO to entity
                _context.Show_release.Update(existingShowRelease);
                await _context.SaveChangesAsync();
            }
        }

        // Delete a ShowRelease
        public async Task DeleteAsync(Guid id)
        {
            var showRelease = await _context.Show_release.FindAsync(id);
            if (showRelease != null)
            {
                _context.Show_release.Remove(showRelease);
                await _context.SaveChangesAsync();
            }
        }
    }

}
