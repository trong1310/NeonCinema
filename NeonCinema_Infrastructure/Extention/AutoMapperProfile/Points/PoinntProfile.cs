using AutoMapper;
using NeonCinema_Application.DataTransferObject.Point;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Points
{
    public class PoinntProfile : Profile
    {
        public PoinntProfile()
        {
            CreateMap<Point, PointDTO>().ReverseMap();
            CreateMap<CreatePointRequest, Point>();
            CreateMap<UpdatePointRequest, Point>();
        }
    }
}
