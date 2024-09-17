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
        public DbSet<Language> Lenguages { get; set; }
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
        public DbSet<TicketSeat> TicketSeats { get; set; }
        public DbSet<Checkin> Checkin { get; set; }
        public DbSet<Seat_ShowTime_Status> Seat_ShowTime_Status { get; set; }
        public DbSet<Show_release> Show_release { get; set; }
        public DbSet<ShowDate> ShowDate { get; set; }
        public DbSet<Point> Points { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            //optionsBuilder.UseSqlServer("Data Source=vantrong\\SQLEXPRESS;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-8GC0563\\LEQUANGHAO29BAVI;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
           // optionsBuilder.UseSqlServer("Data Source=MRG;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");




            //optionsBuilder.UseSqlServer("Data Source=vantrong\\SQLEXPRESS;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
             optionsBuilder.UseSqlServer("Data Source=PHONGKEDAY2\\PHONGKE2004;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeenDingData(modelBuilder);
        }
        private void SeenDingData(ModelBuilder modelBuilder)
        {
            var roleData = new List<Roles>()
            {
                new Roles
                {
                    ID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

                    CreatedTime = DateTimeOffset.Now,
                    Status = EntityStatus.Active,
                    RoleName = "Admin",
                },
                new Roles
                {
                    ID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                    CreatedTime = DateTimeOffset.Now,
                    Status = EntityStatus.Active,
                    RoleName = "Client",
                },  new Roles
                {
                    ID = Guid.Parse("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                    CreatedTime = DateTimeOffset.Now,
                    Status = EntityStatus.Active,
                    RoleName = "Staff",
                },
            };
            modelBuilder.Entity<Roles>(b => { b.HasData(roleData); });
            var userData = new List<Users>()
            {
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    FullName = "Phùng Tiến Giáp",
                    Email = "giapptph39723@fpt.edu.vn",
                    PassWord = Hash.Encrypt("abc123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0862774830",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("25/12/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
				},
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    FullName = "Admin",
                    Email = "admin@gmail.com",
                    PassWord = Hash.Encrypt("admin123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0334555555",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("25/12/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                },
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    FullName = "Client",
                    Email = "client@gmail.com",
                    PassWord = Hash.Encrypt("client123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0334555555",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("25/12/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                },
    // Đặng Xuân Phong (Admin)
    new Users
    {
        ID = Guid.NewGuid(),
        CreatedTime = DateTimeOffset.Now,
        FullName = "Đặng Xuân Phong",
        Email = "dangxuanphong@gmail.com",
        PassWord = Hash.Encrypt("phong123"),
        Status = EntityStatus.Active,
        PhoneNumber = "0334666666",
        Adderss = "Hà Nội",
        DateOrBriht = DateTime.Parse("10/11/1995"),
        Images = "dangxuanphong.jpg",
        Gender = "Nam",
        RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d") // Admin Role
    },
    // Le Quang Hào (Staff)
    new Users
    {
        ID = Guid.NewGuid(),
        CreatedTime = DateTimeOffset.Now,
        FullName = "Le Quang Hào",
        Email = "lequanghao@gmail.com",
        PassWord = Hash.Encrypt("hao123"),
        Status = EntityStatus.Active,
        PhoneNumber = "0334777777",
        Adderss = "Đà Nẵng",
        DateOrBriht = DateTime.Parse("22/07/1993"),
        Images = "lequanghao.jpg",
        Gender = "Nam",
        RoleID = Guid.Parse("56bece24-ba60-4b2b-801c-b68cfc8ccf9d") // Staff Role
    },
    // Nguyễn Văn Trọng (Client)
    new Users
    {
        ID = Guid.NewGuid(),
        CreatedTime = DateTimeOffset.Now,
        FullName = "Nguyễn Văn Trọng",
        Email = "nguyenvantrong@gmail.com",
        PassWord = Hash.Encrypt("trong123"),
        Status = EntityStatus.Active,
        PhoneNumber = "0334888888",
        Adderss = "Hồ Chí Minh",
        DateOrBriht = DateTime.Parse("15/05/1990"),
        Images = "nguyenvantrong.jpg",
        Gender = "Nam",
        RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b") // Client Role
    },
    // Đặng Đức Cường (Client)
    new Users
    {
        ID = Guid.NewGuid(),
        CreatedTime = DateTimeOffset.Now,
        FullName = "Đặng Đức Cường",
        Email = "dangduccuong@gmail.com",
        PassWord = Hash.Encrypt("cuong123"),
        Status = EntityStatus.Active,
        PhoneNumber = "0334999999",
        Adderss = "Quảng Ninh",
        DateOrBriht = DateTime.Parse("08/08/1998"),
        Images = "dangduccuong.jpg",
        Gender = "Nam",
        RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b") // Client Role
    }
            };
			modelBuilder.Entity<Users>(b => { b.HasData(userData); });
		}
    
    }

}


