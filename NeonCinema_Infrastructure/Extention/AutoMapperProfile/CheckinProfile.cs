using AutoMapper;
using NeonCinema_Application.DataTransferObject.Checkins;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class CheckinProfile : Profile
    {
        public CheckinProfile()
        {
            CreateMap<CheckinDTO, Checkin>().ReverseMap();
            CreateMap<CheckinDeleteRequest, Checkin>();
            CreateMap<CheckinUpdateRequest, Checkin>();
        }
    }
}
