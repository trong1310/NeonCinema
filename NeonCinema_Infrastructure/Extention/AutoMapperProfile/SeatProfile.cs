using AutoMapper;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class SeatProfile : Profile
    {
        public SeatProfile() 
        { 
            CreateMap<SeatDTO, Seat>().ReverseMap();
            CreateMap<SeatDeleteRequest, Seat>();
        }
    }
}
