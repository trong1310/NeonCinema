﻿using NeonCinema_Application.DataTransferObject.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.UserFlims
{
    public interface IUserMovies
    {
        public Task<List<MovieDTO>> GetMovieComingsoon(ViewMovieRequest request, CancellationToken cancellationToken);
        public Task<List<MovieDTO>> GetMovieNowShowing(ViewMovieRequest request, CancellationToken cancellationToken);
        public Task<List<MovieDTO>> GetTopMovies(ViewMovieRequest request, CancellationToken cancellationToken);
    }
}
