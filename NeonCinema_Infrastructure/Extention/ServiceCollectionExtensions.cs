using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Interface.Moviess;

using NeonCinema_Application.Interface.Utilities;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement;

using NeonCinema_Infrastructure.Implement.BillDetails;


using NeonCinema_Infrastructure.Implement.MovieDetails;
using NeonCinema_Infrastructure.Implement.MovieType;

using NeonCinema_Infrastructure.Implement.Screenings;
using NeonCinema_Infrastructure.Implement.ShiftChanges;

using NeonCinema_Infrastructure.Implement.Tickets;
using NeonCinema_Infrastructure.Implement.Utilities;
using NeonCinema_Infrastructure.Implement.WorkShift;

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

                //options.UseSqlServer("Data Source=MRG;Initial Catalog=NeonCenima;Integrated Security=True;Trust Server Certificate=True");
            options.UseSqlServer("Server=PHONGKEDAY2\\PHONGKE2004;Database=NeonCenima;Trusted_Connection=True;TrustServerCertificate=True");

            });


            //services.AddTransient<IEmployeesRepository, EmployeesRepository>();
            //services.AddTransient<IWorkShiftRepository, WorkShiftRepository>();
            //services.AddTransient<IShiftChangeRepository, ShiftChangesRepository>();
            //services.AddTransient<IMovieDetailRepository, MovieDetailRepository>();
            //services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IScreeningRepository, ScreeningRepository>();
            //services.AddTransient<IUtilitiesRepository, UtilitiesRespository>();
            //services.AddScoped<IBillDetailsRepository, BillDetailsRepository>();
            services.AddScoped<IEntityRepository<ShowDate>, ShowDateRepository>();
            
            return services;
        }
    }
}

