using AutoMapper;
using NeonCinema_Application.DataTransferObject.FoodCombos;
using NeonCinema_Application.DataTransferObject.Statistics;
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
            CreateMap<FoodCombo, ComboStatisticsDTO>();
            
            
        }
    }
}
