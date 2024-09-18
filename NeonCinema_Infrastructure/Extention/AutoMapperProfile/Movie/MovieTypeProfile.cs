using AutoMapper;
using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Movie
{
    public class MovieTypeProfile : Profile
    {
        public MovieTypeProfile()
        {
            CreateMap<MovieType, MovieTypeDTO>().ReverseMap();
            CreateMap<MovieType,CreateMovieTypeRequest>().ReverseMap();
            CreateMap<MovieType,UpdateMovieTypeRequest>().ReverseMap();
            CreateMap<MovieType,DeleteMovieTypeRequest>().ReverseMap();
        }
    }
}
