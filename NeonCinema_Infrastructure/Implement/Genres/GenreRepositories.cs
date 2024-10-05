using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Point;
using NeonCinema_Application.Interface.Genre;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Genres
{
    public class GenreRepositories : IGenreRepositories
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;

        public GenreRepositories(NeonCinemasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GenreDTO>> GetAllGenres(CancellationToken cancellationToken)
        {
            var query =  _context.Genres.AsNoTracking();
            var genres = await query.ToListAsync();
            return _mapper.Map<List<GenreDTO>>(genres);
        }
        public async Task<GenreDTO> GetGenreById(Guid id, CancellationToken cancellationToken)
        {
            var genre = await _context.Genres.FirstOrDefaultAsync(x => x.ID == id, cancellationToken);
            if (genre == null) return null;
            return _mapper.Map<GenreDTO>(genre);
        }
        public async Task UpdateGenre(Guid id, UpdateGenreRequest request, CancellationToken cancellationToken)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre == null) return;

            _mapper.Map(request, genre);
            _context.Genres.Update(genre);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task CreateGenre(CreateGenreRequest request, CancellationToken cancellationToken)
        {
            var genre = _mapper.Map<Genre>(request);
            _context.Genres.Add(genre);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteGenre(Guid id, CancellationToken cancellationToken)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre == null) return;

            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
