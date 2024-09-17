using AutoMapper;
using NeonCinema_Application.DataTransferObject.Surcharge;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class SurchargeProfile : Profile
    {
        public SurchargeProfile()
        {
            CreateMap<SurchargeDTO, Surcharges>().ReverseMap();
            CreateMap<SurchargeUpdateRequest, Surcharges>();
            CreateMap<SurchargeDeleteRequest, Surcharges>();
        }
    }
}
