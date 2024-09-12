using AutoMapper;
using NeonCinema_Application.DataTransferObject.RankMembers;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention.AutoMapperProfile.RankMembers
{
    public class RankMemberProfile : Profile
    {
        public RankMemberProfile()
        {
            CreateMap<RankMember, RankMemberDTO>().ReverseMap();
            CreateMap<CreateRankMemberRequest, RankMember>();
            CreateMap<UpdateRankMemberRequest, RankMember>();
        }
    }
}
