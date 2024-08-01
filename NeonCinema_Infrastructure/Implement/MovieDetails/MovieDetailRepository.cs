using AutoMapper;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.MovieDetail;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.MovieDetails
{
    public class MovieDetailRepository : IMovieDetailRepository
    {
        private readonly NeonCenimaContext _context;
        private readonly IMapper _mapper;
        public MovieDetailRepository(IMapper mapper)
        {
            _context = new NeonCenimaContext();
            _mapper = mapper;
        }
        public async Task<HttpResponseMessage> Create( MovieDetail requets, CancellationToken cancellationToken)
        {
            try
            {
                if(requets.Duration <=30 || requets.Duration == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Thời lượng phải lớn hơn 30p")
                    };
                }
                if (requets.StarTime < DateTime.Today || requets.StarTime == null )
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Thời gian bắt đầu không hợp lệ")
                    };
                }
                if(requets.EndTime < requets.StarTime || requets.EndTime == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Thời gian kết thúc không hợp lệ")
                    };
                }
                if(requets.AgeAllowed < 8)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Tuổi cho phép quá nhỏ")
                    };
                }

                var detailMovie = new MovieDetail()
                {
                    MovieDetailID = Guid.NewGuid(),
                    ActorID = requets.ActorID,
                    MovieID = requets.MovieID,
                    AgeAllowed = requets.AgeAllowed,
                    StarTime = requets.StarTime,
                    DirectorID = requets.DirectorID,
                    GenreID = requets.GenreID,
                    LenguageID = requets.LenguageID,
                    MovieTypeID = requets.MovieTypeID,
                    Duration = requets.Duration,
                    EndTime = requets.EndTime,
                    Images = requets.Images,

                };
                await _context.MoviesDetails.AddAsync(detailMovie);
                await _context.SaveChangesAsync();
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Add Successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public Task<HttpResponseMessage> Delete(MovieDetail movies, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResponse<MovieDTO>> GetAllMovieDetail(MovieDetailViewRequets requets, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Update(NeonCinema_Domain.Database.Entities.MovieDetail movies, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
