using AutoMapper;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatShowTimeStatus;
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
                CreateMap<Seat, SeatDTO>().ReverseMap();
                CreateMap<Seat, CreateSeatDTO>().ReverseMap();
                CreateMap<Seat, UpdateSeatDTO>().ReverseMap();

            CreateMap<Seat_ShowTime_Status, SeatShowTimeStatusDTO>().ReverseMap();
            CreateMap<Seat_ShowTime_Status, CreateSeatShowTimeStatusDTO>().ReverseMap();
            CreateMap<Seat_ShowTime_Status, UpdateSeatShowTimeStatusDTO>().ReverseMap();
           
            CreateMap<TicketSeat, CreateTicketSeatDTO>().ReverseMap();
            CreateMap<TicketSeat, TicketSeatDTO>().ReverseMap();
            CreateMap<TicketSeat, UpdateTicketSeatDTO>().ReverseMap();

            CreateMap<Show_release, ShowReleaseDTO>().ReverseMap();
            CreateMap<Show_release, CreateShowReleaseDTO>().ReverseMap();
            CreateMap<Show_release, UpdateShowReleaseDTO>().ReverseMap();
            
        }
    }
}
