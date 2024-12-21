
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NeonCinema_Infrastructure.Database.AppDbContext;

namespace NeonCinema_API.Timer
{
	public class TimerProcess : BackgroundService
	{
		private readonly ILogger<TimerProcess> _logger;
		private readonly int TimeLoop = 60000 * 60; // 1 tiếng
		public TimerProcess(ILogger<TimerProcess> loger)
		{
			_logger = loger;
		}
		protected override async Task ExecuteAsync(CancellationToken cancellationToken)
		{
			_logger.LogInformation("Timer Process runtime");

			while (!cancellationToken.IsCancellationRequested)
			{
				await ProcessPendingPoints(cancellationToken);
				await Task.Delay(TimeLoop, cancellationToken);
			}

			_logger.LogInformation($"ScanMatchTimer is stopping.");
		}
		private async Task ProcessPendingPoints(CancellationToken cancellationToken)
		{
			try
			{
				using (var _context = new NeonCinemasContext())
				{
					var pendingPoints = await _context.PendingPoint
									.Where(pp => pp.ApplyDate <= DateTime.UtcNow)
									.ToListAsync(cancellationToken);

					foreach (var point in pendingPoints)
					{
						var accountBook = await _context.RankMembers
							.FirstOrDefaultAsync(rm => rm.UserID == point.UserID, cancellationToken);

						if (accountBook != null)
						{
							accountBook.MinPoint += point.Point;
							accountBook.ModifiedTime = DateTime.UtcNow;

							_context.RankMembers.Update(accountBook);
						}
						
					}
					pendingPoints.ForEach(x =>
					{
						x.ModifiedTime = DateTime.UtcNow;
						x.State = true;
						_context.Update(x);
					});
					await _context.SaveChangesAsync(cancellationToken);
				}
			}
			catch (Exception ex)
			{
				_logger.LogError($"Error {ex.Message} : {ex.StackTrace}");
			}
		}
	}
}
