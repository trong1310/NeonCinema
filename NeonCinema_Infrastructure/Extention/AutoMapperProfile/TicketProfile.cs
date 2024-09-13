using AutoMapper;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<TicketDTO,Ticket>().ReverseMap();
            CreateMap<TicketUpdateRequests, Ticket>();
            CreateMap<TicketDeleteRequests, Ticket>();
        }
    }
}
