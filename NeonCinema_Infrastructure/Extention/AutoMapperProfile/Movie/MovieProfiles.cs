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
            CreateMap<CreateMovieRequest, Movies>();
            CreateMap<Movies, MovieDTO>().ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.Genre.GenreName))
            .ForMember(dest => dest.LanguareName, opt => opt.MapFrom(src => src.Lenguage.LanguageName))
            .ForMember(dest => dest.DirectorName, opt => opt.MapFrom(src => src.Director.FullName))
            .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Countrys.CountryName)); ;
            CreateMap<Movies,UpdateMovieRequest>().ReverseMap();
            CreateMap<Movies,DeleteMovieRequest>().ReverseMap();
            CreateMap<Movies,ViewMovieRequest>().ReverseMap();

        }
    }
}
