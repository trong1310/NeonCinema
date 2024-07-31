using AutoMapper;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task<bool> CreateMovie(Movies movies, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMovie(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<MovieDTO>> GetAllMovies(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<MovieDTO> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMovie(Movies movies, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
