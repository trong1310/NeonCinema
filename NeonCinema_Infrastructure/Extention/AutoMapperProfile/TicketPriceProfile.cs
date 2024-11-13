using AutoMapper;
using NeonCinema_Application.DataTransferObject.TicketPrice;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class TicketPriceProfile : Profile
    {
        public TicketPriceProfile()
        {
            CreateMap<TicketPrice, TicketPriceDTO>();
            CreateMap<TicketPrice, TicketPriceCreateRequest>();
                
        }
    }
}
