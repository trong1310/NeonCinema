using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement;
using NeonCinema_Infrastructure.Implement.Bills;
using NeonCinema_Infrastructure.Implement.Employees;
using NeonCinema_Infrastructure.Implement.Movie;
using NeonCinema_Infrastructure.Implement.Promotions;
using NeonCinema_Infrastructure.Implement.Screenings;
using NeonCinema_Infrastructure.Implement.ShiftChanges;
using NeonCinema_Infrastructure.Implement.Tickets;
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
                options.UseSqlServer("Data Source=MRG;Initial Catalog=NeonCinema;Integrated Security=True;Trust Server Certificate=True");
            });
            services.AddTransient<IEmployeesRepository, EmployeesRepository>();
            services.AddTransient<IWorkShiftRepository, WorkShiftRepository>();
            services.AddTransient<IShiftChangeRepository, ShiftChangesRepository>();
            services.AddTransient<IMovieRepository, MovieRepoitory>();
            services.AddTransient<IPromotionRepository, PromotionRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IScreeningRepository, ScreeningRepository>();
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddTransient<IPromotionTypeRepository, PromotionTypeRepository>();
            return services;
        }
    }
}

