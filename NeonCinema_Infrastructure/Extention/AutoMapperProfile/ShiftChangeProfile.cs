using AutoMapper;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.ShiftChanges;
using NeonCinema_Application.DataTransferObject.WorkShift;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class ShiftChangeProfile: Profile
    {
        public ShiftChangeProfile()
        {
            CreateMap<ShiftChangesCreateRequets, ShiftChange>();
            CreateMap<ShiftChange, ShiftChangesDTO>().ReverseMap();
            CreateMap<ShiftChangesDeleteRequets, ShiftChange>();
            CreateMap<ShiftChangesUpdateRequets, ShiftChange>();
            CreateMap<ShiftChangesViewRequets, ShiftChange>();

        }
    }
}
