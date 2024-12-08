using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.ActorMoives;
using NeonCinema_Application.DataTransferObject.ActorMovies;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace NeonCinema_Infrastructure.Implement.ActorMovies
{
	public class ActorMoviesResp
	{
		private readonly NeonCinemasContext _context;
		private readonly IMapper _mapper;
		public ActorMoviesResp(NeonCinemasContext context, IMapper map)
		{
			_context = context;
			_mapper = map;
		}
		public async Task<HttpResponseMessage> CreateActorMovies(CreateActorMoviesRequest request, CancellationToken cancellationToken)
		{
			try
			{
				var actor = new NeonCinema_Domain.Database.Entities.ActorMovies()
				{
					ActorID = request.ActorID,
					MovieID = request.MovieID,

					CreatedTime = DateTime.UtcNow,
				};
				await _context.ActorMovies.AddAsync(actor);
				await _context.SaveChangesAsync();
				return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
				{
					Content = new StringContent("Thêm thành công")
				};
			}
			catch (Exception ex)
			{
				return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
				{
					Content = new StringContent("Có lỗi" + ex.Message)
				};
			}
		}
		public async Task<List<ActorMoviesDto>> GetActorsByFilmAsync(Guid moviesId, CancellationToken cancellationToken)
		{
			var actorMovies = await _context.ActorMovies
											.Where(x => x.MovieID == moviesId)
											.Include(x => x.Actor)
											.AsNoTracking()
											.Select(x => new ActorMoviesDto
											{
												ActorName = x.Actor.Name
											})
											.ToListAsync(cancellationToken);

			return actorMovies;
		}
		public async Task<bool> UpdateMovieActorsAsync(Guid movieId, List<Guid> actorIds)
		{
			try
			{
				// Tìm phim
				var movie = await _context.Movies
					.Include(m => m.ActorMovies)
					.FirstOrDefaultAsync(m => m.ID == movieId);

				if (movie == null)
				{
					return false;
				}

				// Lấy danh sách ID diễn viên hiện tại
				var currentActorIds = movie.ActorMovies.Select(am => am.ActorID).ToList();

				// Xác định các diễn viên cần xóa
				var actorIdsToRemove = currentActorIds.Except(actorIds).ToList();

				// Xác định các diễn viên cần thêm mới
				var actorIdsToAdd = actorIds.Except(currentActorIds).ToList();

				// Xóa các liên kết diễn viên không còn được chọn
				var actorMoviesToRemove = movie.ActorMovies
					.Where(am => actorIdsToRemove.Contains(am.ActorID))
					.ToList();

				_context.ActorMovies.RemoveRange(actorMoviesToRemove);

				// Thêm các liên kết mới
				foreach (var actorId in actorIds)
				{
					movie.ActorMovies.Add(new NeonCinema_Domain.Database.Entities.ActorMovies
					{
						MovieID = movieId,
						ActorID = actorId
					});
				}

				// Lưu thay đổi
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Lỗi khi cập nhật diễn viên: {ex.Message}");
				return false;
			}
		}
	}
}
