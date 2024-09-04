using AutoMapper;
using NeonCinema_Application.DataTransferObject.MovieDetail;
using NeonCinema_Application.DataTransferObject.MovieType;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class MovieDetailProfile : Profile
    {
        public MovieDetailProfile()
        {
            CreateMap<Movies, MovieDetailDTO>().ReverseMap();
            CreateMap<Movies, MovieDetailUpdateRequets>();
            CreateMap<Movies, MovieDetailCreateRequets>();
            CreateMap<Movies,MovieDetailDeleteRequets>();
            CreateMap<Movies,MovieDetailViewRequets>();

        }
    }
}
