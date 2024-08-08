using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Interface.Moviess;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement;
using NeonCinema_Infrastructure.Implement.Movie;
using NeonCinema_Infrastructure.Implement.MovieDetails;
using NeonCinema_Infrastructure.Implement.Promotions;
using NeonCinema_Infrastructure.Implement.Tickets;
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
            services.AddDbContext<NeonCenimaContext>(options =>
            {
                // Configure your DbContext options here
                options.UseSqlServer("Data Source=MRG;Initial Catalog=NeonCenima;Integrated Security=True;Trust Server Certificate=True");
            });
            services.AddTransient<IMovieDetailRepository,MovieDetailRepository>();
            services.AddTransient<IMovieRepository, MovieRepoitory>();
            services.AddTransient<IPromotionRepository, PromotionRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddTransient<IPromotionTypeRepository, PromotionTypeRepository>();
            return services;
        }
    }
}

