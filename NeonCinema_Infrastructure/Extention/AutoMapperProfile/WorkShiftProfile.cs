using AutoMapper;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.WorkShift;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class WorkShiftProfile: Profile
    {
        public WorkShiftProfile() 
        {
            
            CreateMap<WorkShiftCreateRequets, WorkShift>().ReverseMap();
            CreateMap<WorkShift, WorkShiftDTO>().ReverseMap();
            CreateMap<WorkShiftDeleteRequets, WorkShift>().ReverseMap();
            CreateMap<WorkShiftUpdateRequets, WorkShift>().ReverseMap();
            CreateMap<WorkShiftViewRequets, WorkShift>().ReverseMap();
        }
    }
}
