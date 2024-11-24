using AutoMapper;
using NeonCinema_Application.DataTransferObject.TicketPriceSetting;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.TicketPriceSettings
{
    public class TicketPriceSettingProfile : Profile
    {
        public TicketPriceSettingProfile()
        {
            CreateMap<TicketPriceSettingDTO, TicketPriceSetting>().ReverseMap();
        }
    }
}
