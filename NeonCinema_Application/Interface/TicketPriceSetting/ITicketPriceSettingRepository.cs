using NeonCinema_Application.DataTransferObject.TicketPriceSetting;
using NeonCinema_Application.DataTransferObject.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.TicketPriceSetting
{
	public interface ITicketPriceSettingRepository
	{
		Task<TicketPriceSettingDTO> GetByIdAsync(Guid id);
		public Task<HttpResponseMessage> Update(TicketPriceSettingDTO request);
	}
}
