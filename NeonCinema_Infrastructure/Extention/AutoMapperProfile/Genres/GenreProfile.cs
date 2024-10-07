using AutoMapper;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.GenreProfile
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Category, GenreDTO>().ReverseMap();
            CreateMap<CreateGenreRequest, Category>();
            CreateMap<UpdateGenreRequest, Category>();
        }
    }
}
