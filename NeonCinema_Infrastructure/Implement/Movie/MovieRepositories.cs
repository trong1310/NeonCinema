using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.ActorMovies;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;


namespace NeonCinema_Infrastructure.Implement.Movie
{
	public class MovieRepositories : IMovieRepositories
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _maps;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public MovieRepositories(IMapper maps, IWebHostEnvironment hv)
        {
            _webHostEnvironment = hv;
            _context = new NeonCinemasContext();
            _maps = maps;
        }
        public async Task<HttpResponseMessage> Create(CreateMovieRequest request, CancellationToken cancellationToken)
        {
			try
			{
				var movies = new Movies()
				{
					ID = Guid.NewGuid(),
					Duration = request.Duration,
					Name = request.Name,
					Trailer = request.Trailer,
					Description = request.Description,
					StarTime = request.StarTime,
					Images = request.Images,
					AgeAllowed = request.AgeAllowed,
					Status = MovieStatus.upcomingkrelease,
					GenreID = request.GenreID,
					LenguageID = request.LenguageID,
					CountryID = request.CountryID,
					DirectorID = request.DirectorID,
					CreatedTime = DateTime.Now,
					Sub = request.Sub,
					MovieTypeID = request.MovieTypeID,

				};
				await _context.Movies.AddAsync(movies);
				await _context.SaveChangesAsync(cancellationToken);
                var actorMovies = request.ActorMovies.Select(x => new NeonCinema_Domain.Database.Entities.ActorMovies
                {
                    MovieID = movies.ID,
                    ActorID = x,
                }).ToList();
                await _context.ActorMovies.AddRangeAsync(actorMovies);
                await _context.SaveChangesAsync();
				return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
				{
					Content = new StringContent("Thêm thành công")

				};
			}
			catch (Exception ex)
			{
				return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
				{
					Content = new StringContent("có lỗi xảy ra" + ex.Message)
				};
			}
		}
        public async Task<HttpResponseMessage> Delete(Movies request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Movies.FirstOrDefaultAsync(x => x.ID == request.ID);
                if (obj != null)
                {
                    obj.Deleted = true;
                    obj.DeletedTime = DateTime.Now;
                    _context.Movies.Update(obj);
                    await _context.SaveChangesAsync(cancellationToken);
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                    {
                        Content = new StringContent("Đã xóa thành công")
                    };

                }
                else
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Không tìm thấy phim")
                    };
                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("có lỗi xảy ra" + ex.Message)
                };
            }
        }
        public async Task<PaginationResponse<MovieDTO>> GetAll(ViewMovieRequest request, CancellationToken cancellationToken)
        {

            var query = _context.Movies
                            .Include(x => x.Genre)
                            .Include(x => x.Screening)
                            .Include(x => x.Director)
                            .Include(x => x.Lenguage)
                            .Include(x => x.Countrys)
                            .Include(x => x.TicketSeats)
							.AsNoTracking();
			if (!string.IsNullOrWhiteSpace(request.SearchName))
            {
                query = query.Where(x => x.Name.Contains(request.SearchName.ToLower()));
            }

            var result = await query.PaginateAsync<Movies, MovieDTO>(request, _maps, cancellationToken);
            var dataview = (from a in result.Data
                            join b in query on a.ID
                            equals b.ID orderby b.CreatedTime descending
							where b.Deleted == false
							select new MovieDTO
                            {
                                ID = b.ID,
                                AgeAllowed = b.AgeAllowed,
                                Trailer = b.Trailer,
                                Status = b.Status,
                                Name = b.Name,
                                Images = b.Images,
                                StarTime = b.StarTime,
                                Duration = b.Duration,
                                Description = b.Description,
                                LanguareName = b.Lenguage.LanguageName,
                                CountryName = b.Countrys.CountryName,
                                DirectorName = b.Director.FullName,
                                GenreName = b.Genre.GenreName,

                            }).ToList();

            return new PaginationResponse<MovieDTO>()
            {
                Data = dataview,
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize
            };
        }
        public async Task<MovieDTO> GetById(Guid id, CancellationToken cancellationToken)
        {
            var movie = await _context.Movies
                .Include(x => x.Genre)
                .Include(x => x.Screening)
                .Include(x => x.Director)
                .Include(x => x.Lenguage)
                .Include(x => x.Countrys)
                .Include(x => x.TicketSeats)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == id, cancellationToken);

            if (movie == null)
            {
                return null;
            }

            var movieDTO = new MovieDTO
            {
                ID = movie.ID,
                AgeAllowed = movie.AgeAllowed,
                Trailer = movie.Trailer,
                Status = movie.Status,
                Name = movie.Name,
                Images = movie.Images,
                StarTime = movie.StarTime,
                Duration = movie.Duration,
                Description = movie.Description,
                LanguareName = movie.Lenguage.LanguageName,
                CountryName = movie.Countrys.CountryName,
                DirectorName = movie.Director.FullName,
                GenreName = movie.Genre.GenreName,
            };

            return movieDTO;
        }
		public async Task<HttpResponseMessage> Update(UpdateMovieRequest request, CancellationToken cancellationToken)
		{
			try
			{
				var obj = await _context.Movies.FirstOrDefaultAsync(x => x.ID == request.ID);
				if (obj == null || obj.Deleted == true)
				{
					return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
					{
						Content = new StringContent("Không tìm thấy phim")
					};
				}

				// Cập nhật thông tin cơ bản của phim
				obj.Duration = request.Duration;
				obj.Name = request.Name;
				obj.Status = request.Status;
				obj.AgeAllowed = request.AgeAllowed;
				obj.CountryID = request.CountryID;
				obj.Description = request.Description;
				obj.DirectorID = request.DirectorID;
				obj.Trailer = request.Trailer;
				obj.GenreID = request.GenreID;
				obj.LenguageID = request.LenguageID;
				obj.StarTime = request.StarTime;
				obj.ModifiedTime = DateTime.UtcNow;
				obj.Images = request.Images;

				// Cập nhật danh sách diễn viên
				var existingActors = await _context.ActorMovies
					.Where(am => am.MovieID == obj.ID)
					.ToListAsync(cancellationToken);

				// Lấy danh sách ActorID mới từ request
				var newActorIDs = request.ActorMovies;

				// Tìm các diễn viên cần xóa
				var actorsToRemove = existingActors
					.Where(am => !newActorIDs.Contains(am.ActorID))
					.ToList();

				// Tìm các diễn viên cần thêm mới
				var actorsToAdd = newActorIDs
					.Where(actorID => !existingActors.Any(am => am.ActorID == actorID))
					.Select(actorID => new NeonCinema_Domain.Database.Entities.ActorMovies
					{
						MovieID = obj.ID,
						ActorID = actorID
					}).ToList();

				// Xóa diễn viên cũ
				_context.ActorMovies.RemoveRange(actorsToRemove);

				// Thêm diễn viên mới
				await _context.ActorMovies.AddRangeAsync(actorsToAdd, cancellationToken);

				// Cập nhật thông tin phim
				_context.Movies.Update(obj);

				// Lưu thay đổi
				await _context.SaveChangesAsync(cancellationToken);

				return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
				{
					Content = new StringContent("Sửa thành công")
				};
			}
			catch (Exception ex)
			{
				return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
				{
					Content = new StringContent("Có lỗi xảy ra: " + ex.Message)
				};
			}
		}

		public async Task<List<MovieDTO>> GetFilmsNowShowing()
        {
            var query = await _context.Movies
                .Include(x => x.Genre)
                .Include(x => x.Screening)
                .Include(x => x.Director)
                .Include(x => x.Lenguage)
                .Include(x => x.Countrys)
                .Include(x => x.TicketSeats)
                .Where(x => x.Status == MovieStatus.isreleasing)
                .OrderByDescending(x => x.CreatedTime) 
                .AsNoTracking()
                .ToListAsync();

            if (query == null || !query.Any()) return null;
            var actor = await _context.ActorMovies.Include(x => x.Actor).AsNoTracking().ToListAsync();
            var movieDtos = query.Select(result => new MovieDTO
            {
                ID = result.ID,
                Name = result.Name,
                AgeAllowed = result.AgeAllowed,
                CountryName = result.Countrys.CountryName,
                Description = result.Description,
                DirectorName = result.Director.FullName,
                Duration = result.Duration,
                GenreName = result.Genre.GenreName,
                Images = result.Images,
                LanguareName = result.Lenguage.LanguageName,
                StarTime = result.StarTime, // Đảm bảo tên thuộc tính đúng nếu không sẽ gây lỗi
                Status = result.Status,
                Trailer = result.Trailer,
                ActorMovies = actor.Where(x=>x.MovieID == result.ID).Select(act => new ActorMoviesDto
                {
                    ActorName = act.Actor.Name,
                }).ToList(),
            }).ToList();

            return movieDtos;
        }
		public async Task<List<MovieDTO>> GetFilmsComing()
		{
			var query = await _context.Movies
				.Include(x => x.Genre)
				.Include(x => x.Screening)
				.Include(x => x.Director)
				.Include(x => x.Lenguage)
				.Include(x => x.Countrys)
				.Include(x => x.TicketSeats)
				.Where(x => x.Status == MovieStatus.upcomingkrelease)
				.OrderByDescending(x => x.CreatedTime) 
				.AsNoTracking()
				.ToListAsync();

			if (query == null || !query.Any()) return null;

			var movieDtos = query.Select(result => new MovieDTO
			{
				ID = result.ID,
				Name = result.Name,
				AgeAllowed = result.AgeAllowed,
				CountryName = result.Countrys.CountryName,
				Description = result.Description,
				DirectorName = result.Director.FullName,
				Duration = result.Duration,
				GenreName = result.Genre.GenreName,
				Images = result.Images,
				LanguareName = result.Lenguage.LanguageName,
				StarTime = result.StarTime, // Đảm bảo tên thuộc tính đúng nếu không sẽ gây lỗi
				Status = result.Status,
				Trailer = result.Trailer,
			}).ToList();

			return movieDtos;
		}


		public async Task<List<MovieDTO>> GetFilmsStopShowing()
		{
			var query = await _context.Movies
				.Include(x => x.Genre)
				.Include(x => x.Screening)
				.Include(x => x.Director)
				.Include(x => x.Lenguage)
				.Include(x => x.Countrys)
				.Include(x => x.TicketSeats)
				.Where(x => x.Status == MovieStatus.StopShowing)
				.OrderByDescending(x => x.CreatedTime)
				.AsNoTracking()
				.ToListAsync();

			if (query == null || !query.Any()) return null;

			var movieDtos = query.Select(result => new MovieDTO
			{
				ID = result.ID,
				Name = result.Name,
				AgeAllowed = result.AgeAllowed,
				CountryName = result.Countrys.CountryName,
				Description = result.Description,
				DirectorName = result.Director.FullName,
				Duration = result.Duration,
				GenreName = result.Genre.GenreName,
				Images = result.Images,
				LanguareName = result.Lenguage.LanguageName,
				StarTime = result.StarTime, // Đảm bảo tên thuộc tính đúng nếu không sẽ gây lỗi
				Status = result.Status,
				Trailer = result.Trailer,
			}).ToList();

			return movieDtos;
		}
	}
}
