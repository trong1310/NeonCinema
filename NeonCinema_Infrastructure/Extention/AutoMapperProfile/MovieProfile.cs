using AutoMapper;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {   
            CreateMap<MovieCreateRequets,Movies>();
            CreateMap<Movies,MovieDTO>().ReverseMap();     
            CreateMap<MovieDeleteRequets,Movies>();
            CreateMap<MovieUpdateRequets,Movies>();
            CreateMap<MovieViewRequets,Movies>();
        }
    }
}
