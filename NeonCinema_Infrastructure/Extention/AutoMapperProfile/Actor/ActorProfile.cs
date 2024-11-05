using AutoMapper;
using Com.CloudRail.SI.ServiceCode.Commands;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile
{
    public class ActorProfile : Profile
    {
        public ActorProfile()
        {
            CreateMap<Actor, ActorDTO>().ReverseMap();
            CreateMap<Actor, CreateActorRequest>().ReverseMap();
        }
    }
}
