using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NeonCinema_Infrastructure.Database.AppDbContext;
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
                //options.UseSqlServer("Server=vantrong\\SQLEXPRESSvantrong\\SQLEXPRESS;Database=NeonCenima;Trusted_Connection=True;TrustServerCertificate=True");
                options.UseSqlServer("Server=PHONGKEDAY2\\PHONGKE2004;Database=NeonCenima;Trusted_Connection=True;TrustServerCertificate=True");

            });
            return services;
        }
    }
}

