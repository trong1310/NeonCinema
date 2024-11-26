using NeonCinema_Application.DataTransferObject.TicketPriceSetting;

namespace NeonCinema_Client.Data.IServices.TicketPriceSetting
{
	public interface ITicketPriceSettingService
	{
		Task<TicketPriceSettingDTO> GetByIdAsync(Guid id);
		public Task<HttpResponseMessage> Update(TicketPriceSettingDTO request);
	}
}
