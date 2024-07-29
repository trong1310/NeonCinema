using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.AppDbContext
{
    public class NeonCenimaContext : DbContext
    {
        public NeonCenimaContext()
        {
            
        }
        public NeonCenimaContext(DbContextOptions<NeonCenimaContext> options) : base(options)
        {
            
        }
        #region DbSet
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Cenima> Cenima { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Employees> Employees { get; set; } 
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Lenguage> Lenguages { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }
        public DbSet<MovieDetail> MoviesDetails { get; set; }
        public DbSet<Movies> Movies {  get; set; }
        public DbSet<MovieType> MoviesType { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<PromotionCustomer> PromotionCustomers { get; set; }
        public DbSet<PromotionType> PromotionTypes { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Room> Room { get; set; }   
        public DbSet<Screening> Screening { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceOder> ServiceOder { get; set; }
        public DbSet<ShiftChange> ShiftChange { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<WorkShift> WorkShift { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=vantrong\\SQLEXPRESS;Database=NeonCenima;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
