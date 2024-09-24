using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Movie;
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

               
               
                string fileRoot = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
                if (!Directory.Exists(fileRoot))
                {
                    Directory.CreateDirectory(fileRoot);
                }

                string trailerfile = Guid.NewGuid() + Path.GetExtension(request.Images.FileName);
                string trailerFilePath = Path.Combine(fileRoot, trailerfile);
                using (var fileStream = new FileStream(trailerFilePath, FileMode.Create))
                {
                    request.Images.CopyTo(fileStream);
                }
                var movies = new Movies()
                {
                    ID = Guid.NewGuid(),

                    Duration = request.Duration,
                    Name = request.Name,
                    Trailer = request.Trailer,
                    Description = request.Description,
                    StarTime = request.StarTime,
                    Images = $"/Resources/{trailerfile}",
                    AgeAllowed = request.AgeAllowed,
                    Status = MovieStatus.Comingsoon,
                    GenreID = request.GenreID,
                    LenguageID = request.LenguageID,
                    CountryID = request.CountryID,
                    DirectorID = request.DirectorID,
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
            var query = _context.Movies.Include(x => x.Genre).Include(x => x.Screening).Include
      (x => x.Director).Include(x => x.Lenguage).Include(x => x.Countrys).AsNoTracking();
            if (!string.IsNullOrWhiteSpace(request.SearchName))
            {
                query = query.Where(x=>x.Name.Contains(request.SearchName.ToLower()));
            }
           
            var result = await query.PaginateAsync<Movies, MovieDTO>(request, _maps, cancellationToken);
            var dataView = (from a in result.Data
                            join b in query on a.ID
                            equals b.ID 
                          
                            orderby b.StarTime 
                            where b.Deleted == false
                            select new MovieDTO
                            {
                                AgeAllowed = b.AgeAllowed,
                                Trailer = b.Trailer,
                                Status = b.Status,
                                StarTime = b.StarTime,
                                Name = b.Name,
                                Duration = b.Duration,
                                Description = b.Description,
                                LanguareName = b.Lenguage.LanguageName,
                                CountryName = b.Countrys.CountryName,
                                DirectorName = b.Director.FullName,
                                GenreName = b.Genre.GenreName,
                                
                                
                            }).ToList();
            return new PaginationResponse<MovieDTO>()
            {
                Data = result.Data,
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                 PageSize = result.PageSize,
                
            };
        }

        public async Task<List<MovieDTO>> GetMovieComingsoon(ViewMovieRequest request, CancellationToken cancellationToken)
        {
            var query = _context.Movies.Include(x => x.Genre).Include(x => x.Screening).Include
               (x => x.Director).Include(x => x.Lenguage).Include(x => x.Countrys).AsNoTracking();
          //  var result = await query.Where(x=>x.Status == MovieStatus.Comingsoon).ToListAsync();
            var result = await query.PaginateAsync<Movies, MovieDTO>(request, _maps, cancellationToken);
            var dataview = (from a in result.Data
                            join b in query on a.ID
                            equals b.ID
                            orderby b.StarTime
                            where b.Status == MovieStatus.Comingsoon

                            select new MovieDTO
                            {
                                ID = b.ID,
                                AgeAllowed = b.AgeAllowed,
                                Trailer = b.Trailer,
                                Status = b.Status,
                                StarTime = b.StarTime,
                                Name = b.Name,
                                Duration = b.Duration,
                                Images = b.Images,
                                Description = b.Description,
                                LanguareName = b.Lenguage.LanguageName,
                                CountryName = b.Countrys.CountryName,
                                DirectorName = b.Director.FullName,
                                GenreName = b.Genre.GenreName,
                            }).ToList();
            return dataview;
        }

        public async Task<List<MovieDTO>> GetMovieNowShowing(ViewMovieRequest request, CancellationToken cancellationToken)
        {

            var query = _context.Movies.Include(x => x.Genre).Include(x => x.Screening).Include
               (x => x.Director).Include(x => x.Lenguage).Include(x => x.Countrys).AsNoTracking();
            var result = await query.PaginateAsync<Movies, MovieDTO>(request, _maps, cancellationToken);
            var dataview = (from a in result.Data
                            join b in query on a.ID
                            equals b.ID
                            orderby b.StarTime
                            where b.Status == MovieStatus.Active

                            select new MovieDTO
                            {
                                ID = b.ID,
                                AgeAllowed = b.AgeAllowed,
                                Trailer = b.Trailer,
                                Status = b.Status,
                                StarTime = b.StarTime,
                                Images = b.Images,
                                Name = b.Name,
                                Duration = b.Duration,
                                Description = b.Description,
                                LanguareName = b.Lenguage.LanguageName,
                                CountryName = b.Countrys.CountryName,
                                DirectorName = b.Director.FullName,
                                GenreName = b.Genre.GenreName,
                            }).ToList();
            return dataview;
        }

        public async Task<HttpResponseMessage> Update(Movies request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Movies.FirstOrDefaultAsync(x => x.ID == request.ID);
                if(obj.Deleted == true && obj == null)
                {

                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Không tìm thấy phim")
                    };
                }
                request.Duration = obj.Duration;
                request.Name = obj.Name;
                request.Status = obj.Status;
                request.AgeAllowed = obj.AgeAllowed;
                request.CountryID = obj.CountryID;
                request.Description = obj.Description;
                request.DirectorID = obj.DirectorID;
                request.Trailer = obj.Trailer;
                request.GenreID = obj.GenreID;
                request.LenguageID = obj.LenguageID;
                request.StarTime = obj.StarTime;
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
