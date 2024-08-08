using NeonCinema_Application.DataTransferObject.MovieType;
using NeonCinema_Application.Interface.Moviess;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NeonCinema_Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace NeonCinema_Infrastructure.Implement.MovieType
{
    public class MovieTypeRepository : IMovieTypeRepository

    {
        private readonly NeonCenimaContext _context;
        private readonly IMapper _mapper;
        public MovieTypeRepository(NeonCenimaContext context , IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(NeonCinema_Domain.Database.Entities.MovieType request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.MovieTypeName == null) 
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Please enter enough")
                    };
                }
                var newMovieType = new NeonCinema_Domain.Database.Entities.MovieType() 
                { 
                    MovieTypeID = request.MovieTypeID,
                    MovieTypeName = request.MovieTypeName,
                };
                await _context.MoviesType.AddAsync(newMovieType);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Add MovieType Successfully")
                };
            }
            catch(Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> Delete(NeonCinema_Domain.Database.Entities.MovieType request, CancellationToken cancellationToken)
        {
            var movieType = _context.MoviesType.FirstOrDefault(x => x.MovieTypeID == request.MovieTypeID);
            if (movieType == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("MovieType NotFound")
                };
            }
            movieType.Deleted = true;
            _context.MoviesType.Update(movieType);
            await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Update MovieType Successfully")
            };

        }

        public async Task<List<MovieTypeDTO>> GetAll( CancellationToken cancellationToken)
        {
            var movieType = await _context.MoviesType.ToListAsync(cancellationToken);
            return _mapper.Map<List<MovieTypeDTO>>(movieType);
        }

        public async Task<HttpResponseMessage> Update(NeonCinema_Domain.Database.Entities.MovieType request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.MoviesType.FirstOrDefaultAsync(x=>x.MovieTypeID == request.MovieTypeID);
                if (obj == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound)
                    {
                        Content = new StringContent("MovieType NotFound")
                    };
                }
               obj.MovieTypeName = request.MovieTypeName;
                obj.ModifiedTime = request.ModifiedTime;
                _context.MoviesType.Update(obj);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Update MovieType Successfully")
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
