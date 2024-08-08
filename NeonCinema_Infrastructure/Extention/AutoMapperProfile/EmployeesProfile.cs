using AutoMapper;
using NeonCinema_Application.DataTransferObject.Employees;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class EmployeesProfile: Profile
    {
        public EmployeesProfile() 
        { 
            CreateMap<EmployeesDTO, Employees>().ReverseMap();
            CreateMap<EmployeesCreateRequest, Employees>().ReverseMap();
            CreateMap<EmployeesUpdateRequest, Employees>().ReverseMap();
            CreateMap<EmployessViewRequest, Employees>().ReverseMap();
           
        }
    }
}
