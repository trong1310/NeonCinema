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
            CreateMap<MovieDetail, MovieDetailDTO>().ReverseMap();
            CreateMap<MovieDetail, MovieDetailUpdateRequets>();
            CreateMap<MovieDetail, MovieDetailCreateRequets>();
            CreateMap<MovieDetail,MovieDetailDeleteRequets>();
            CreateMap<MovieDetail,MovieDetailViewRequets>();

        }
    }
}
