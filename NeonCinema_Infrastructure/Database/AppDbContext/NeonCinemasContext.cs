using Bogus;
using Bogus.Hollywood;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.Configuration;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.AppDbContext
{
    public class NeonCinemasContext : DbContext
    {
        public NeonCinemasContext()
        {

        }
        public NeonCinemasContext(DbContextOptions<NeonCinemasContext> options) : base(options)
        {

        }
        #region DbSet
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Bill> BillDetails { get; set; }
        public DbSet<Cinemas> Cinema { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Lenguage> Lenguages { get; set; }
        public DbSet<RankMember> RankMembers { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Countrys> Country { get; set; }
        public DbSet<ShowTime> ShowTimes { get; set; }
        public DbSet<BookTickets> BookTickets { get; set; }
        public DbSet<MovieType> MoviesType { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Surcharges> Surcharges { get; set; }
        public DbSet<Screening> Screening { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<FoodCombo> FoodCombos { get; set; }
        public DbSet<ShiftChange> ShiftChange { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<WorkShift> WorkShift { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<CategoryMovies> CategoryMovies { get; set; }
        public DbSet<CinemasType> CinemasTypes { get; set; }
        public DbSet<TicketSeat> TicketSeats { get; set; }
        public DbSet<Checkin> Checkin { get; set; }
        public DbSet<Seat_ShowTime_Status> Seat_ShowTime_Status { get; set; }
        public DbSet<Show_release> Show_release { get; set; }
        public DbSet<ShowDate> ShowDate { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=vantrong\\SQLEXPRESS;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //FakeData(modelBuilder);
        }
    
    }

}


