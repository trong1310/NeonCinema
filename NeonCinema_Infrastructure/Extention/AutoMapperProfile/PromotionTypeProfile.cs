using AutoMapper;
using NeonCinema_Application.DataTransferObject.PromotionTypes;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class PromotionTypeProfile: Profile
    {
        public PromotionTypeProfile() {
            CreateMap<PromotionType, PromotionTypesDTO>().ReverseMap();
         
            CreateMap<PromotionType, PromotionTypeCreateRequest>().ReverseMap();
            CreateMap<PromotionType, UpdatePromotionTypeRequest>().ReverseMap();
            CreateMap<PromotionType, PromotionTypeViewRequest>().ReverseMap();
        }
       
    }
}
