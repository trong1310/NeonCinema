using AutoMapper;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Seats
{
    public class SeatTypeProfile : Profile
    {
        public SeatTypeProfile()
        {
            CreateMap<SeatType, SeatTypeDTO>().ReverseMap();
            CreateMap<SeatType, CreateSeatTypeDTO>().ReverseMap();
            CreateMap<SeatType, UpdateSeatTypeDTO>().ReverseMap();
        }
    }
}
