using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Application.DataTransferObject.FoodCombos;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace NeonCinema_Infrastructure.Implement.FoodCombo_R
{
	public class FoodComboRepository
	{
		private readonly NeonCinemasContext _context;
		public FoodComboRepository(NeonCinemasContext context)
		{
			_context = context;
		}
		public async Task<List<FoodComboDTO>> GetAll(CancellationToken cancellationToken)
		{
			var food = await _context.FoodCombos.Select(x => new FoodComboDTO
			{
				ID = x.ID,
				Amount = x.TotalPrice,
				Content = x.Content,
				Description = x.Description,
				Images = x.Images,
			}).ToListAsync();
			return food;
		}
		public async Task<FoodComboDTO> CreateFoodCombo(FoodComboCreateRequest request)
		{
			var checkcombo = _context.FoodCombos.Where(x => x.Content == request.Content).ToList();
			if (checkcombo.Any())
			{
				throw new Exception("FoodCombo với nội dung này đã tồn tại.");
			}
			var foods = new FoodCombo()
			{
				Content = request.Content,
				ID = Guid.NewGuid(),
				TotalPrice = (decimal)request.TotalPrice,
				CreatedTime = DateTime.Now,
				Description = request.Description,
				Images = request.Images,
				Deleted = false,
			};
			try
			{
				await _context.FoodCombos.AddAsync(foods);
				await _context.SaveChangesAsync();
				var dto = new FoodComboDTO
				{
					ID = foods.ID,
					Amount = foods.TotalPrice,
					Content = foods.Content,
					Description = foods.Description,
					Images = foods.Images,
				};
				return dto;
			}
			catch (Exception ex) 
			{
				throw new Exception($"Error {ex.Message} : {ex.StackTrace}");
			}

		}
		public async Task<FoodComboDTO> DetailCombo(Guid id)
		{
			var query= await _context.FoodCombos.Where(x=>x.ID ==id).FirstOrDefaultAsync();
			if (query == null)
			{
				return null;
			}
			var respones = new FoodComboDTO()
			{
				ID= id,
				Amount = query.TotalPrice,
				Content = query.Content,
				Description = query.Description,
				Images = query.Images,
				
			};
			return respones;
		}
		public async Task<FoodComboDTO> UpdateCombo(FoodComboUpdateRequest request)
		{
			var query = await _context.FoodCombos.Where(x => x.ID == request.ID).FirstOrDefaultAsync();
			if (query == null)
			{
				return null;
			}
			query.Content = request.Content;	
			query.Description = request.Description;
			query.ID = request.ID;
			query.TotalPrice = (decimal)request.Amount;
			query.Images = request.Images;
			_context.FoodCombos.Update(query);
			await _context.SaveChangesAsync();
			var respones = new FoodComboDTO()
			{
				ID = query.ID,
				Amount = query.TotalPrice,
				Content = query.Content,
				Description = query.Description,
				Images = query.Images,

			};
			return respones;
		}
	}
}
