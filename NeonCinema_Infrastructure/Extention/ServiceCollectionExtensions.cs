using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NeonCinema_Application.Interface.Genre;
using NeonCinema_Application.Interface.Point;
using NeonCinema_Application.Interface.RannkMember;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Interface.SeatShowTimeStatus;
using NeonCinema_Application.Interface.SeatType;
using NeonCinema_Application.Interface.ShowReleases;
using NeonCinema_Application.Interface.TicketSeats;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement.Genres;
using NeonCinema_Infrastructure.Implement.Points;
using NeonCinema_Infrastructure.Implement.RankMembers;
using NeonCinema_Infrastructure.Implement.Seat;
using NeonCinema_Infrastructure.Implement.Seats;
using NeonCinema_Infrastructure.Implement.SeatShowTimeStatus;
using NeonCinema_Infrastructure.Implement.Show_release;
using NeonCinema_Infrastructure.Implement.TicketSeats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Extention
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NeonCinemasContext>(options =>
            {

                //options.UseSqlServer("Data Source=MRG;Initial Catalog=NeonCenima;Integrated Security=True;Trust Server Certificate=True");
                options.UseSqlServer("Server=vantrong\\SQLEXPRESSvantrong\\SQLEXPRESS;Database=NeonCenima;Trusted_Connection=True;TrustServerCertificate=True");

            });


            services.AddTransient<IPointRepositories, PointRepositories>();
            services.AddTransient<IRankMemberRepository, RankMemberRepositories>();
            services.AddTransient<IGenreRepositories, GenreRepositories>();
            services.AddTransient<ISeatRepository, SeatRepository>();
            services.AddTransient<ITicketSeatRepository, TicketSeatRepository>();
            services.AddTransient<ISeatShowTimeStatusRepository, SeatShowTimeStatusRepository>();
            services.AddTransient<IShowReleaseRepository, ShowReleaseRepository>();
            return services;
        }
    }
}

