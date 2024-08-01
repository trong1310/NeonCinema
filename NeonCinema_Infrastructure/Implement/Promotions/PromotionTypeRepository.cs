using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.PromotionTypes;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Promotions
{
    public class PromotionTypeRepository : IPromotionTypeRepository

    {
        private readonly NeonCenimaContext _context;
        private readonly IMapper _mapper;
        public PromotionTypeRepository(NeonCenimaContext context,IMapper mapper)
        {
                _context = context;
            _mapper = mapper;
        }
        public async Task<PromotionTypesDTO> CreateAsync(PromotionTypeCreateRequest request, CancellationToken cancellationToken)
        {
            request.PromotionTypeID = Guid.NewGuid();
            var promotionType = _mapper.Map<PromotionType>(request);
            
            _context.PromotionTypes.Add(promotionType);
            await _context.SaveChangesAsync(cancellationToken);
            return _mapper.Map<PromotionTypesDTO>(promotionType);
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var promotionType = await _context.PromotionTypes.FindAsync(new object[] { id }, cancellationToken);
            if (promotionType == null) return false;

            _context.PromotionTypes.Remove(promotionType);
            await _context.SaveChangesAsync(cancellationToken);
            return true;

        }

        public async Task<IEnumerable<PromotionTypesDTO>> GetAllAsync(PaginationRequest paginationParams, CancellationToken cancellationToken)
        {
            var promotionTypes = await _context.PromotionTypes
            .Skip((paginationParams.PageNumber - 1) * paginationParams.PageSize)
            .Take(paginationParams.PageSize)
            .ToListAsync(cancellationToken);
            return _mapper.Map<IEnumerable<PromotionTypesDTO>>(promotionTypes);
        }

        public async Task<PromotionTypesDTO> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var promotionType = await _context.PromotionTypes.FirstOrDefaultAsync(x => x.PromotionTypeID == id , cancellationToken);
            return _mapper.Map<PromotionTypesDTO>(promotionType);
        }

        public async Task<PromotionTypesDTO> UpdateAsync(Guid id, PromotionTypeCreateRequest request, CancellationToken cancellationToken)
        {
            var promotionType = await _context.PromotionTypes.FindAsync(id, cancellationToken);
            if (promotionType == null) return null;

            _mapper.Map(request, promotionType);
            promotionType.PromotionName = request.PromotionName;
            promotionType.Status = request.Status;
            await _context.SaveChangesAsync(cancellationToken);
            return _mapper.Map<PromotionTypesDTO>(promotionType);
        }
    }
}
