using AutoMapper;
using NeonCinema_Application.DataTransferObject.PromotionCustomers;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.DataTransferObject.PromotionTypes;
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
        public PromotionProfile() {

            CreateMap<Promotion, PromotionDTO>().ReverseMap();
            CreateMap<CreatePromotionRequest, Promotion>().ReverseMap();
            CreateMap<UpdatePromotionRequest, Promotion>().ReverseMap();

            CreateMap<PromotionType, PromotionTypesDTO>().ReverseMap();
            CreateMap<Promotion ,PromotionViewRequest>().ReverseMap();

            CreateMap<PromotionCustomer, PromotionCustomersDTO>();

        }
    }
}
