using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement
{
    public class PromotionRepository : IPromotionRepository
    {
        private readonly NeonCenimaContext _context;
        private readonly IMapper _mapper;

        public PromotionRepository(NeonCenimaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddPromotionAsync(Promotion promotion, CancellationToken cancellationToken)
        {
            try
            {
                promotion.PromotionID = Guid.NewGuid();
                promotion.CreatedTime = DateTime.UtcNow;
                promotion.ModifiedTime = DateTime.UtcNow;
              
                await _context.Promotion.AddAsync(promotion, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception)
            {
                // Log the exception if necessary
                return false;
            }
        }

        public async Task<bool> DeletePromotionAsync(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var promotion = await _context.Promotion.FindAsync(id);
                if (promotion != null)
                {
                    _context.Promotion.Remove(promotion);
                    await _context.SaveChangesAsync(cancellationToken);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                // Log the exception if necessary
                return false;
            }
        }

        public async Task<List<PromotionDTO>> GetAllPromotionsAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Promotion
                .Where(x => x.CreatedBy == id && x.DeletedTime == null) // Fetch only active promotions
                .ProjectTo<PromotionDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }

        public async Task<PromotionDTO> GetPromotionByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Promotion
                .Where(x => x.PromotionID == id && x.DeletedTime == null) // Fetch only active promotions
                .ProjectTo<PromotionDTO>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<bool> UpdatePromotionAsync(Promotion promotion, CancellationToken cancellationToken)
        {
            try
            {
                var existingPromotion = await _context.Promotion.FindAsync(promotion.PromotionID);
                if (existingPromotion == null)
                {
                    return false;
                }

                existingPromotion.Quantity = promotion.Quantity;
                existingPromotion.Status = promotion.Status;
                existingPromotion.Discount = promotion.Discount;
                existingPromotion.StarDate = promotion.StarDate;
                existingPromotion.EndDate = promotion.EndDate;
                existingPromotion.Description = promotion.Description;
                existingPromotion.proviso = promotion.proviso;
                existingPromotion.ModifiedTime = DateTime.UtcNow;

                _context.Promotion.Update(existingPromotion);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception)
            {
                // Log the exception if necessary
                return false;
            }
        }
    }
}
