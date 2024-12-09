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
	}
}
