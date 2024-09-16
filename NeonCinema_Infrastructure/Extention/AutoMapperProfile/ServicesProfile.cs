using AutoMapper;
using NeonCinema_Application.DataTransferObject.Services;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class ServicesProfile : Profile
    {
        public ServicesProfile() 
        {
            CreateMap<ServicesDTO, Service>().ReverseMap();
            CreateMap<ServicesDeleteRequest, Service>();
            CreateMap<ServicesUpdateRequest, Service>();
        }
    }
}
