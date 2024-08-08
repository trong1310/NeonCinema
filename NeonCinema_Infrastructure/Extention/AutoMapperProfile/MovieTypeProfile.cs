using AutoMapper;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.MovieType;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class MovieTypeProfile : Profile
    {
        public MovieTypeProfile()
        {
            CreateMap<MovieTypeCreateRequest, MovieType>();
            CreateMap<MovieType, MovieTypeDTO>().ReverseMap();
            CreateMap<MovieTypeUpdateRequest, MovieType>();
            CreateMap<MovieTypeViewRequets, MovieType>();
            CreateMap<MovieTypeDeleteRequets, MovieType>();
        }
    }
}
