using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NeonCinema_Application.Interface;

using NeonCinema_Application.Interface.Actors;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement;
using NeonCinema_Infrastructure.Implement.Actors;

using NeonCinema_Application.Interface.Genre;
using NeonCinema_Application.Interface.Point;
using NeonCinema_Application.Interface.RannkMember;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement;
using NeonCinema_Infrastructure.Implement.Genres;
using NeonCinema_Infrastructure.Implement.Points;
using NeonCinema_Infrastructure.Implement.RankMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeonCinema_Application.Interface.Directors;
using NeonCinema_Infrastructure.Implement.Directors;

namespace NeonCinema_Infrastructure.Extention
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NeonCinemasContext>(option => {
                option.UseSqlServer("Data Source=vantrong\\SQLEXPRESS;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            });
            
            services.AddTransient<ISeatTypeRepository, SeatTypeRepository>();
            services.AddTransient<IActorRepositories, ActorRepositories>();
            services.AddTransient<ISeatTypeRepository, SeatTypeRepository>();
            services.AddTransient<IPointRepositories, PointRepositories>();
            services.AddTransient<IRankMemberRepository, RankMemberRepositories>();
            services.AddTransient<IGenreRepositories, GenreRepositories>();
            services.AddTransient<IDirectorRepositories, DirectorRepositories>();
            return services;
        }
    }
}

