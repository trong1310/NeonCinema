using AutoMapper;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class ScreeningProfile : Profile
    {
        public ScreeningProfile() 
        {
            CreateMap<ScreeningCreateRequest, Screening>();
            CreateMap<ScreeningUpdateRequest, Screening>();
            CreateMap<Screening, ScreeningDTO>()
     .ForMember(dest => dest.ShowTime, opt => opt.MapFrom(src => src.ShowTime.StartTime));
            CreateMap<SeatShowTimeStatusDTO, SeatShowTimeStatus>().ReverseMap();
            CreateMap<ScreeningSupportValidate, Screening >().ReverseMap();
			CreateMap<ShowTimeDTO, ScreeningSupportValidate>();
		}

    }
}
