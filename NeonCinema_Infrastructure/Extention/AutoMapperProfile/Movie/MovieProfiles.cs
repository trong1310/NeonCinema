using AutoMapper;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Movie
{
    public class MovieProfiles : Profile
    {
        public MovieProfiles()
        {
            CreateMap<Movies, MovieDTO>().ReverseMap();
            CreateMap<Movies,CreateMovieRequest>().ReverseMap();
            CreateMap<Movies,UpdateMovieRequest>().ReverseMap();
            CreateMap<Movies,DeleteMovieRequest>().ReverseMap();
            CreateMap<Movies,ViewMovieRequest>().ReverseMap();

        }
    }
}
