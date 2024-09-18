using AutoMapper;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.Point;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Languages
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<Language, LanguageDTO>().ReverseMap();
            CreateMap<CreateLanguageRequest, Language>();
            CreateMap<UpdateLanguageRequest, Language>();
        }
    }
}
