using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Promotion_R
{
	public class PromoHub : Hub
	{
		public async Task NotifyPromotionStatus(string message)
		{
			await Clients.All.SendAsync("ReceiveLog", message);
		}
	}
}
