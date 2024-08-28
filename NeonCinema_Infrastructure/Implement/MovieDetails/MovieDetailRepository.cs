using AutoMapper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;

using NeonCinema_Application.DataTransferObject.MovieDetail;
using NeonCinema_Application.Interface.Moviess;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public async Task<HttpResponseMessage> Delete(MovieDetail movies, CancellationToken cancellationToken)
        {
            try
            {
                var objDele = _context.MoviesDetails.FindAsync(movies.MovieDetailID, cancellationToken);
                if (objDele == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("MovieDetail not found")
                    };
                }
                movies.Deleted = true;
                _context.MoviesDetails.Update(movies);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Successfully")
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

        public Task<PaginationResponse<MovieDetailDTO>> GetAllMovieDetail(MovieDetailViewRequets requets, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //public async Task<PaginationResponse<MovieDetailDTO>> GetAllMovieDetail(MovieDetailViewRequets requets, CancellationToken cancellationToken)
        //{
        //   var query = _context.MoviesDetails.Include(x => x.Movies).AsNoTracking();
        //    if (!String.IsNullOrWhiteSpace(requets.ActorID.ToString()))
        //    {
        //        query = query.Where(x => x.ActorID.ToString().Contains(requets.ActorID.ToString()));
        //    }
        //    else if (!String.IsNullOrWhiteSpace(requets.DirectorName))
        //    {
        //        query = query.Where(x => x.Director.FullName.Contains(requets.DirectorName));
        //    }
        //    else if (!String.IsNullOrWhiteSpace(requets.Lenguage))
        //    {
        //        query = query.Where(x => x.Lenguage.LenguageName.Contains(requets.Lenguage));
        //    }
        //    else if (!String.IsNullOrWhiteSpace(requets.Genre))
        //    {
        //        query = query.Where(x => x.Genre.GenreName.Contains(requets.Genre));
        //    }
        //    else if (!String.IsNullOrWhiteSpace(requets.MovieTypeName))
        //    {
        //        query = query.Where(x => x.MovieType.MovieTypeName.Contains(requets.MovieTypeName));
        //    }
        //    else if (requets.AgeAllowed.HasValue)
        //    {
        //        query = query.Where(x => x.AgeAllowed >= requets.AgeAllowed);
        //    }
        //    var result =await query.PaginateAsync<MovieDetail,MovieDetailDTO> (requets,_mapper,cancellationToken);
        //        result.Data = (from a in result.Data
        //                       join b in query on 
        //                       a.MovieDetailID equals b.MovieDetailID
        //                       select new MovieDetailDTO
        //                       { 
        //                           ActorID = b.ActorID,
        //                           DirectorID = b.DirectorID,
        //                           MovieDetailID = b.MovieDetailID,
        //                           AgeAllowed = b.AgeAllowed,
        //                           Duration = b.Duration,
        //                           EndTime = b.EndTime,
        //                           GenreID = b.GenreID,
        //                           Images = b.Images,
        //                           LenguageID = b.LenguageID,
        //                           MovieID = b.MovieID,
        //                           MovieTypeID = b.MovieTypeID,
        //                           StarTime = b.StarTime

        //                       } 
        //                       ).ToList();
        //    return new PaginationResponse<MovieDetailDTO>
        //    {
        //        HasNext = result.HasNext,
        //        Data = result.Data,
        //        PageNumber = result.PageNumber,
        //        PageSize = result.PageSize,
        //    };
        //}

        public async Task<HttpResponseMessage> Update(MovieDetail movies, CancellationToken cancellationToken)
        {
            try
            {
                var objMovieDetail = await _context.MoviesDetails.FirstOrDefaultAsync(x => x.MovieDetailID == movies.MovieDetailID);
                if (objMovieDetail == null) 
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound)
                    {
                        Content = new StringContent("MovieDetail Not Found")
                    };
                }
                objMovieDetail.ActorID = movies.ActorID;
                objMovieDetail.AgeAllowed   = movies.AgeAllowed;
                objMovieDetail.DirectorID = movies.DirectorID;
                objMovieDetail.Duration = movies.Duration;
                objMovieDetail.StarTime = movies.StarTime;
                objMovieDetail.EndTime = movies.EndTime;
                objMovieDetail.GenreID = movies.GenreID;
                objMovieDetail.LenguageID = movies.LenguageID;
                objMovieDetail.MovieTypeID = movies.MovieTypeID;
                objMovieDetail.Images = movies.Images;
                _context.Update(objMovieDetail);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Updated Successfully")
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
