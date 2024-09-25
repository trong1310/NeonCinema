using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Interface.UserFlims;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.UserMovies
{
    public class UserMoviess : IUserMovies
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _maps;
        public UserMoviess(IMapper map)
        {
            _context = new NeonCinemasContext();
            _maps = map;
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

        public async Task<List<MovieDTO>> GetTopMovies(ViewMovieRequest request, CancellationToken cancellationToken)
        {
            var query = _context.Movies
                             .Include(x => x.Genre)
                             .Include(x => x.Screening)
                             .Include(x => x.Director)
                             .Include(x => x.Lenguage)
                             .Include(x => x.Countrys)
                             .Include(x => x.TicketSeats)
                             .AsNoTracking();
            int ticketCount;
            var result = await query.Where(x=>x.Status == MovieStatus.Active).Select(movies=>new
            {
                Movies = movies,
                ticketCount = movies.TicketSeats.Count(),
            }
            ).OrderByDescending(x=>x.ticketCount).Take(6).Select(b=> new MovieDTO
            {
                ID = b.Movies.ID,
                AgeAllowed = b.Movies.AgeAllowed,
                Trailer = b.Movies.Trailer,
                Status = b.Movies.Status,
                StarTime = b.Movies.StarTime,
                Images = b.Movies.Images,
                Name = b.Movies.Name,
                Duration = b.Movies.Duration,
                Description = b.Movies.Description,
                LanguareName = b.Movies.Lenguage.LanguageName,
                CountryName = b.Movies.Countrys.CountryName,
                DirectorName = b.Movies.Director.FullName,
                GenreName = b.Movies.Genre.GenreName,
            }).ToListAsync();
            return result;  
        }
    }
}
