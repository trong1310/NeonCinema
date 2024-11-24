using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.TicketPriceSetting;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Interface.TicketPriceSetting;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.TicketPriceSetting
{
	public class TicketPriceSettingRepository : ITicketPriceSettingRepository
	{
		private readonly NeonCinemasContext _context;
		private readonly IMapper _map;
		public TicketPriceSettingRepository(NeonCinemasContext context, IMapper map)
        {
            _context = context;
			_map = map;
        }

		public async Task<TicketPriceSettingDTO> GetByIdAsync(Guid id)
		{
			var obj = await _context.TicketPriceSettings.FindAsync(id);
			return _map.Map<TicketPriceSettingDTO>(obj);

		}

		public async Task<HttpResponseMessage> Update(TicketPriceSettingDTO request)
		{
			try
			{
				var obj = await _context.TicketPriceSettings.FirstOrDefaultAsync(x => x.ID == request.ID);
				if (obj == null)
				{

					return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
					{
						Content = new StringContent("Không tìm thấy giá vé")
					};
				}
				obj.PriceBefore17hWeekeend = request.PriceBefore17hWeekeend;
				obj.PriceAfter17hWeekeend = request.PriceAfter17hWeekeend;
				obj.PriceAfter17hWeekDay = request.PriceAfter17hWeekDay;
				obj.PriceBefore17hWeekDay = request.PriceBefore17hWeekDay;
				obj.Surcharge3D = request.Surcharge3D;
				obj.Surcharge4D = request.Surcharge4D;
				obj.SurchargeIMAX = request.SurchargeIMAX;
				obj.SurchargeCouple = request.SurchargeCouple;
				obj.SurchargeVIP = request.SurchargeVIP;
				_context.TicketPriceSettings.Update(obj);
				await _context.SaveChangesAsync();
				return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
				{
					Content = new StringContent("Sửa thành công")
				};
			}
			catch (Exception ex)
			{
				return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
				{
					Content = new StringContent("có lỗi xảy ra" + ex.Message)
				};
			}

		}

		
	}
}
