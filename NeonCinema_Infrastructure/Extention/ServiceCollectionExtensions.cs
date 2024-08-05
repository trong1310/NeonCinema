using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeonCinema_Application.Interface;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement.Movie;
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


                options.UseSqlServer("Data Source=PHONGKEDAY2\\PHONGKE2004;Initial Catalog=NeonCenima;Integrated Security=True;Trust Server Certificate=True");

            });
            services.AddTransient<IMovieRepository, MovieRepoitory>();
            return services;
        }
    }
}

