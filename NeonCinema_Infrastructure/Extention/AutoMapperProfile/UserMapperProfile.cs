using AutoMapper;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class UserMapperProfile:Profile
    {
        public UserMapperProfile() 
        {
            CreateMap<Users, UserDTO>().ReverseMap();
            CreateMap<Users, UserCreateRequest>().ReverseMap();
            CreateMap<Users, UserUpdateRequest>().ReverseMap();
        }
    }
}
