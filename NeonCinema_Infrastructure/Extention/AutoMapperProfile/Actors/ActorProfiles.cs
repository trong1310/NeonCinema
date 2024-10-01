using AutoMapper;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.Actors
{
    public class ActorProfiles : Profile
    {
        public ActorProfiles() 
        {
            CreateMap<Actor, ActorDTO>().ReverseMap();
            CreateMap<Actor, CreateActorRequest>().ReverseMap();
            CreateMap<Actor, UpdateActorRequest>().ReverseMap();
            CreateMap<Actor, DeleteActorRequest>().ReverseMap();
        }
    }
}
