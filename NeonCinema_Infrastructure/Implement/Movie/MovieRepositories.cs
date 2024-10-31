using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;



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
                    Status = MovieStatus.Comingsoon,
                    GenreID = request.GenreID,
                    LenguageID = request.LenguageID,
                    CountryID = request.CountryID,
                    DirectorID = request.DirectorID,
                    Actor = request.Actor,
                    CreatedTime = DateTime.Now,

                };
                await _context.Movies.AddAsync(movies);
                await _context.SaveChangesAsync(cancellationToken);
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
                            equals b.ID
                            orderby b.StarTime

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
                                Actor = b.Actor

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
                Actor = movie.Actor,
            };

            return movieDTO;
        }

        public async Task<HttpResponseMessage> Update(UpdateMovieRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Movies.FirstOrDefaultAsync(x => x.ID == request.ID);
                if (obj.Deleted == true && obj == null)
                {

                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Không tìm thấy phim")
                    };
                }
                obj.Duration = request.Duration ;
                obj.Name = request.Name;
                obj.Status = request.Status;
                obj.AgeAllowed = request.AgeAllowed;
                obj.CountryID = request.CountryID;
                obj.Description = request.Description;
                obj.DirectorID = request.DirectorID;
                obj.Trailer = request.Trailer;
                obj.GenreID = request.GenreID;
                obj.LenguageID = request.LenguageID;

                obj.Actor = request.Actor;

                obj.StarTime = request.StarTime;
                obj.ModifiedTime = DateTime.UtcNow;
                _context.Movies.Update(obj);
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
                    Content = new StringContent("có lỗi xảy ra" + ex.Message)
                };
            }
        }
    }
}
