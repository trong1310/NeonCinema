using AutoMapper;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class PromotionProfile : Profile
    {
        public PromotionProfile() 
        {
            CreateMap<PromotionDTO, Promotion>().ReverseMap();
            CreateMap<PromotionCreateRequest, Promotion>();
            CreateMap<PromotionDeleteRequest, Promotion>();

            CreateMap<PromotionUserDTO, PromotionUsers>().ReverseMap();
        }
    }
}
