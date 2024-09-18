using AutoMapper;
using NeonCinema_Application.DataTransferObject.CategoryMovies;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Movie
{
    public class CategoryMovieProfile : Profile
    {
        public CategoryMovieProfile()
        {
            CreateMap<CategoryMovies, CategoryDTO>().ReverseMap();
            CreateMap<CategoryMovies, CreateCategoryMovies>().ReverseMap();
            CreateMap<CategoryMovies, UpdateCategoryRequest>().ReverseMap();
            CreateMap<CategoryMovies, DeleteCategoryRequest>().ReverseMap();
        }
    }
}
