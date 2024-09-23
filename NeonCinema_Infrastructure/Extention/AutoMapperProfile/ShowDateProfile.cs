using AutoMapper;
using NeonCinema_Application.DataTransferObject.ShowDate;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class ShowDateProfile : Profile
    {
        public ShowDateProfile()
        {
            CreateMap<ShowDateDTO, ShowDate>().ReverseMap();
            CreateMap<ShowDateUpdateRequest, ShowDate>();
            CreateMap<ShowDateCreateRequest, ShowDate>();
            // Thêm ánh xạ này
        }
    }
}
