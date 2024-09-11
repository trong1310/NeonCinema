using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NeonCinema_Application.Interface;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement;
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
            services.AddTransient<ISeatTypeRepository, SeatTypeRepository>();
            return services;
        }
    }
}

