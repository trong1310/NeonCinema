using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Movie
{
    public class MovieRepoitory : IMovieRepository
    {
        private readonly NeonCenimaContext _reps;
        private readonly IMapper _maper;

        public MovieRepoitory( IMapper maper)
        {
            _reps = new NeonCenimaContext();
            _maper = maper;
        }

        public async Task<HttpResponseMessage> CreateMovie(Movies movies, CancellationToken cancellationToken)
        {
            try
            {
                if (movies.MovieName == null || movies.Description == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest) 
                    {
                        Content = new StringContent("Please enter enough")
                    };   
                }
                var findByName = await _reps.Movies.FirstOrDefaultAsync(x=>x.MovieName == movies.MovieName);
                if (findByName != null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Movies already exist")
                    };
                }
                var movieCreate = new Movies()
                {
                    MovieID = Guid.NewGuid(),
                    MovieName = movies.MovieName,
                    Description = movies.Description,
                    Status = MovieStatus.PendingForApproval,
                    CreatedTime = DateTimeOffset.Now,
                };
                await _reps.Movies.AddAsync(movieCreate);
                await _reps.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Created successfully")
                };
                

            }
            catch (Exception ex) 
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> DeleteMovie(Movies id, CancellationToken cancellationToken)
        {
            try
            {
                var deleObj = await _reps.Movies.FirstOrDefaultAsync(x => x.MovieID == id.MovieID);
                if (deleObj == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Movie not found")
                    };
                }
                    deleObj.Deleted = true;
                    _reps.Movies.Update(deleObj);
                    await _reps.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Deleted successfully")
                };

            }
            catch (Exception ex) 
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<PaginationResponse<MovieDTO>> GetAllMovies(MovieViewRequets requets, CancellationToken cancellationToken)
        {
            var query = _reps.Movies.Include(x=>x.MovieDetails).AsNoTracking();
            if (!String.IsNullOrWhiteSpace(requets.MovieName))
            {
                query = query.Where(x => x.MovieName.Contains(requets.MovieName));
            }
            var result = await query.PaginateAsync<Movies, MovieDTO>(requets, _maper, cancellationToken);
            result.Data = (from x in result.Data
                           join y in query on 
                           x.MovieID equals y.MovieID
                           orderby y.CreatedTime descending 
                           select new MovieDTO
                           {
                               MovieID = y.MovieID,
                               MovieName = y.MovieName,
                               Description = y.Description,
                               Status = y.Status
                           }
                           ).ToList();
            return new PaginationResponse<MovieDTO>()
            {
                HasNext = result.HasNext,
                Data = result.Data,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
            };
        }

        private async Task<MovieDTO> GetById(Guid id, CancellationToken cancellationToken)
        {
            var movies = await _reps.Movies.FindAsync(id,cancellationToken);
            return _maper.Map<MovieDTO>(id);
        }

        public async Task<HttpResponseMessage> UpdateMovie(Movies requets, CancellationToken cancellationToken)
        {
            try
            {
                var movies = await _reps.Movies.FirstOrDefaultAsync(x => x.MovieID == requets.MovieID);
                if (movies == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Movie not found")
                    };
                }
                movies.MovieName = requets.MovieName;
                movies.Status = requets.Status;
                movies.Description = requets.Description;
                 _reps.Movies.Update(movies);
                await _reps.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Updated successfully")
                };
            }
            catch (Exception ex) 
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }
    }
}
