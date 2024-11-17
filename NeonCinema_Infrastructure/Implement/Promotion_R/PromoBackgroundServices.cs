
using Microsoft.EntityFrameworkCore;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Domain.Enum;
using Microsoft.JSInterop;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;
using NeonCinema_Infrastructure.Implement.Promotion_R;

namespace NeonCinema_Client.Data.Services.Promotion
{
	public class PromoBackgroundServices : BackgroundService
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IHubContext<PromoHub> _hubcontext;

		public PromoBackgroundServices(IServiceProvider serviceProvider, IHubContext<PromoHub> hubcontext)
		{
			_serviceProvider = serviceProvider;
			_hubcontext = hubcontext;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{
				using var scope = _serviceProvider.CreateScope();
				var dbContext = scope.ServiceProvider.GetRequiredService<NeonCinemasContext>();

				var now = DateTime.UtcNow;

				// Lấy tất cả mã khuyến mại cần kiểm tra
				var promotions = await dbContext.Promotions.ToListAsync(stoppingToken);

				foreach (var promo in promotions)
				{
					// Kiểm tra thời gian bắt đầu
					if (promo.StartDate <= now && now < promo.EndDate && promo.Status == PromotionStatus.InActive)
					{
						promo.Status = PromotionStatus.Active;
						await _hubcontext.Clients.All.SendAsync("ReceiveLog", $"Promotion '{promo.Code}' activated", stoppingToken);
					}
					// Kiểm tra thời gian kết thúc
					else if (now >= promo.EndDate)
					{
						promo.Status = PromotionStatus.Expired;
						await _hubcontext.Clients.All.SendAsync("ReceiveLog", $"Promotion '{promo.Code}' expired", stoppingToken);
					}
				}

				await dbContext.SaveChangesAsync(stoppingToken);

				// Đợi 1 phút trước khi kiểm tra lại
				await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
			}
		}
	}
}
