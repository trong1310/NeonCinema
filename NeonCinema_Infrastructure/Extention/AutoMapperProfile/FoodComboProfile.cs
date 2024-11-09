using AutoMapper;
using NeonCinema_Application.DataTransferObject.FoodCombos;
using NeonCinema_Application.DataTransferObject.StaticStatis;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class FoodComboProfile : Profile
    {
        public FoodComboProfile()
        {
            CreateMap<FoodComboDTO, FoodCombo>().ReverseMap();
            CreateMap<FoodComboDeleteRequest, FoodCombo>();
            CreateMap<FoodComboUpdateRequest, FoodCombo>();
            CreateMap<FoodCombo, FoodComboDto>()
             .ForMember(dest => dest.ServiceName, opt => opt.MapFrom(src => src.Service!.ServiceName))
             .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
             .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.TotalPrice));
        }
    }
}
