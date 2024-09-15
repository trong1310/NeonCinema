using AutoMapper;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class ShowTimeProfile : Profile
    {
        public ShowTimeProfile()
        {
            CreateMap<ShowTimeDTO, ShowTime>().ReverseMap();
            CreateMap<ShowTimeDeleteRequest, ShowTime>();
            CreateMap<ShowTimeUpdateRequest, ShowTime>();
        }
    }
}
