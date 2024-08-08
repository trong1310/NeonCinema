using AutoMapper;
using NeonCinema_Application.DataTransferObject.PromotionCustomers;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class PromotionCustomerProfile : Profile
    {
        public PromotionCustomerProfile()
        {

            CreateMap<PromotionCustomer, CreatePromotionCustomerRequest>().ReverseMap();
            CreateMap<PromotionCustomer, UpdatePromotionCustomerRequest>().ReverseMap();
            CreateMap<PromotionCustomer, PromotionCustomerViewRequest>().ReverseMap();
            CreateMap<PromotionCustomer, PromotionCustomersDTO>().ReverseMap();
        }
    }
}
