using AutoMapper;
using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class BillProfile : Profile
    {
        public BillProfile()
        {
            CreateMap<BillDTO, Bill>().ReverseMap();
            CreateMap<BillUpdateRequest, Bill>();
            CreateMap<BillDeleteRequest, Bill>();
            CreateMap<Users, ViewBillUserRequest>();
        }
    }
}
