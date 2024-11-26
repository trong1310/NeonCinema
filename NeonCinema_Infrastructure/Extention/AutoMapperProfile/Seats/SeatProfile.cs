using AutoMapper;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.DataTransferObject.ShowRelease;
using NeonCinema_Application.DataTransferObject.TicketSeats;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Seats
{
    public class SeatProfile : Profile
    {
        public SeatProfile()
        {
            CreateMap<Seat, SeatDTO>();
            CreateMap<SeatTypeDTO, SeatType>();
            CreateMap<Seat, SeatDTO>().ReverseMap();
                CreateMap<Seat, CreateSeatDTO>().ReverseMap();
                CreateMap<Seat, UpdateSeatDTO>().ReverseMap();
           
            CreateMap<Ticket, CreateTicketSeatDTO>().ReverseMap();
            CreateMap<Ticket, TicketSeatDTO>().ReverseMap();
            CreateMap<Ticket, UpdateTicketSeatDTO>().ReverseMap();

            CreateMap<Show_release, ShowReleaseDTO>().ReverseMap();
            CreateMap<Show_release, CreateShowReleaseDTO>().ReverseMap();
            CreateMap<Show_release, UpdateShowReleaseDTO>().ReverseMap();
            
        }
    }
}
