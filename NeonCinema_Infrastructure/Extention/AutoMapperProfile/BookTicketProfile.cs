using AutoMapper;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class BookTicketProfile : Profile
    {
        public BookTicketProfile()
        {
            CreateMap<CreateBookTicketRequest, BookTickets>();
            CreateMap<Screening,ScreeningMoviesDto>().ReverseMap();
        }
    }
}
