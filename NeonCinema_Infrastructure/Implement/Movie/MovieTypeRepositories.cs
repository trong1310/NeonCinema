
using Microsoft.EntityFrameworkCore;

using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Movie
{
    public class MovieTypeRepositories : IMovieTypeRepositories
    {
        private readonly NeonCinemasContext _context;

        public MovieTypeRepositories(NeonCinemasContext context)
        {
            _context = context;

        }

        public async Task<MovieTypeDTO> CreateMovieType(CreateMovieTypeRequest request, CancellationToken cancellationToken)
        {
            var MVT = new MovieType
            {
                ID = Guid.NewGuid(), // Generate a new ID
                MovieTypeName = request.MovieTypeName,
                // Example status
            };

            // Add the actor to the context and save changes
            await _context.MoviesType.AddAsync(MVT, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            // Manually map the Actor entity to ActorDTO
            var MVTDTO = new MovieTypeDTO
            {
                ID = MVT.ID,
                MovieTypeName = MVT.MovieTypeName,

            };

            return MVTDTO;
        }

        public async Task<List<MovieTypeDTO>> GetAllMovieType(CancellationToken cancellationToken)
        {
            var MVT = await _context.MoviesType.ToListAsync(cancellationToken);

            // Manually map the list of Actor entities to a list of ActorDTOs
            var actorDTOs = MVT.Select(MoViE => new MovieTypeDTO
            {
                ID = MoViE.ID,
                MovieTypeName = MoViE.MovieTypeName,

            }).ToList();

            return actorDTOs;
        }

        public async Task<MovieTypeDTO> GetMovieTypeById(Guid id, CancellationToken cancellationToken)
        {
            var MVT = await _context.MoviesType.FindAsync(new object[] { id }, cancellationToken);
            if (MVT == null)
            {
                return null;
            }

            // Manually map the Actor entity to ActorDTO
            var DTO = new MovieTypeDTO
            {
                ID = MVT.ID,
                MovieTypeName = MVT.MovieTypeName,

            };

            return DTO;
        }

        public async Task<HttpResponseMessage> UpdateMovieType(Guid id, UpdateMovieTypeRequest request, CancellationToken cancellationToken)
        {
            var MVT = await _context.MoviesType.FindAsync(new object[] { id }, cancellationToken);
            if (MVT == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
                {
                    Content = new StringContent("MOvie Type not found.")
                };
            }

            // Update the properties

            MVT.MovieTypeName = request.MovieTypeName;


            await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("movietype updated successfully.")
            };
        }
    }
}
