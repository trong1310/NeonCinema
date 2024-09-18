﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeonCinema_Application.Interface;

using NeonCinema_Domain.Database.Entities;

using NeonCinema_Application.Interface.Actors;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement;
using NeonCinema_Infrastructure.Implement.Actors;

using NeonCinema_Application.Interface.Genre;
using NeonCinema_Application.Interface.Point;
using NeonCinema_Application.Interface.RannkMember;
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

using NeonCinema_Infrastructure.Implement.Screenings;
using NeonCinema_Infrastructure.Implement.Tickets;
using NeonCinema_Infrastructure.Database.Configuration;
using NeonCinema_Infrastructure.Implement.Surcharge;
using NeonCinema_Infrastructure.Implement.Bills;

using NeonCinema_Infrastructure.Implement.Checkin_R;
using NeonCinema_Infrastructure.Implement.FoodCombo_R;
using NeonCinema_Infrastructure.Implement.Services_R;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Interface.SeatShowTimeStatus;
using NeonCinema_Application.Interface.ShowReleases;
using NeonCinema_Application.Interface.TicketSeats;
using NeonCinema_Infrastructure.Implement.Seats;
using NeonCinema_Infrastructure.Implement.TicketSeats;
using NeonCinema_Infrastructure.Implement.SeatShowTimeStatus;
using NeonCinema_Infrastructure.Implement.Show_release;
using NeonCinema_Application.Interface.Language;
using NeonCinema_Infrastructure.Implement.Languages;


namespace NeonCinema_Infrastructure.Extention
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NeonCinemasContext>(options =>
            {

                //options.UseSqlServer("Data Source=MRG;Initial Catalog=NeonCenima;Integrated Security=True;Trust Server Certificate=True");
                options.UseSqlServer("Server=PHONGKEDAY2\\PHONGKE2004;Database=NeonCenima;Trusted_Connection=True;TrustServerCertificate=True");
    
             });

            
            
            services.AddTransient<ISeatTypeRepository, SeatTypeRepository>();
            services.AddTransient<IActorRepositories, ActorRepositories>();
            services.AddTransient<ISeatTypeRepository, SeatTypeRepository>();
            services.AddTransient<IPointRepositories, PointRepositories>();
            services.AddTransient<IRankMemberRepository, RankMemberRepositories>();
            services.AddTransient<IGenreRepositories, GenreRepositories>();
            services.AddTransient<IDirectorRepositories, DirectorRepositories>();

            services.AddScoped<IScreeningRepository, ScreeningRepository>();
            services.AddScoped<IEntityRepository<ShowDate>, ShowDateRepository>();
            services.AddScoped<IEntityRepository<ShowTime>, ShowTimeRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IEntityRepository<BookTickets>, BookTicketRepository>();
            services.AddScoped<IEntityRepository<Surcharges>, SurchargeRepository>();
            services.AddScoped<IEntityRepository<Bill>, BillRepository>();
            services.AddScoped<IEntityRepository<Checkin>, CheckinRepository>();
            services.AddScoped<IEntityRepository<FoodCombo>, FoodComboRepository>();
            services.AddScoped<IEntityRepository<Service>, ServicesRepository>();
            services.AddScoped<ISeatRepository, SeatRepository>();
            services.AddTransient<ITicketSeatRepository, TicketSeatRepository>();
            services.AddTransient<ISeatShowTimeStatusRepository, SeatShowTimeStatusRepository>();
            services.AddTransient<IShowReleaseRepository, ShowReleaseRepository>();
            services.AddTransient<ILanguageRepositories, LanguageRepositories>();

            return services;
        }
    }
}

