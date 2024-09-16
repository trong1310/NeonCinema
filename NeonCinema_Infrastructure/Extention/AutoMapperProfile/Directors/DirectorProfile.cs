using AutoMapper;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Directors
{
    public class DirectorProfile : Profile
    {
        public DirectorProfile() 
        {
            CreateMap<Director,DirectorDTO>().ReverseMap();
            CreateMap<Director,CreateDirectorRequest>().ReverseMap();
            CreateMap<Director,UpdateDirectorRequest>().ReverseMap();
            CreateMap<Director,DeleteDirectorRequest>().ReverseMap();
        }
    }
}
