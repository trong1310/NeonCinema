using AutoMapper;
using NeonCinema_Application.DataTransferObject.Screenings;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class ScreeningProfile : Profile
    {
        public ScreeningProfile() 
        { 
            CreateMap<ScreeningDTO, Screening>().ReverseMap();
        }

    }
}
