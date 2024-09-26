﻿using Bogus;
using Bogus.Hollywood;
using Bogus.Hollywood.Models;
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
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionUsers> PromotionUsers { get; set; }
        public DbSet<PromotionMovie> PromotionMovies { get; set; }
        public DbSet<PromotionCode> PromotionCodes { get; set; }
      
        public DbSet<PromotionType> promotionTypes { get; set; }
        public DbSet<BillPromotion> billPromotions { get; set; }
       
        

        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=PHONGKEDAY2\\PHONGKE2004;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer("Data Source=CUONG;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Promotion>()
        .HasOne(p => p.PromotionType)  // Một Promotion có một PromotionType
        .WithMany(pt => pt.Promotions)  // Một PromotionType có nhiều Promotion
        .HasForeignKey(p => p.PromotionTypeID)  // Promotion có khóa ngoại PromotionTypeID
        .OnDelete(DeleteBehavior.Cascade);  // Xóa PromotionType sẽ xóa các Promotion liên quan
            modelBuilder.Entity<PromotionUsers>()
         .HasOne(pu => pu.Promotion)
         .WithMany(p => p.PromotionUsers)
         .HasForeignKey(pu => pu.PromotionID);

            modelBuilder.Entity<PromotionUsers>()
                .HasOne(pu => pu.User)
                .WithMany(u => u.PromotionUsers)
                .HasForeignKey(pu => pu.UserID);


            modelBuilder.Entity<PromotionMovie>()
                .HasOne(pm => pm.Promotion)
                .WithMany(p => p.PromotionMovies)
                .HasForeignKey(pm => pm.PromotionID);

            modelBuilder.Entity<PromotionMovie>()
                .HasOne(pm => pm.Movies)
                .WithMany(m => m.PromotionMovies)
                .HasForeignKey(pm => pm.MovieID);
            modelBuilder.Entity<BillPromotion>()
                .HasOne(pm => pm.Bill)
                .WithMany(m => m.BillPromotions)
                .HasForeignKey(pm => pm.BillID); 
            modelBuilder.Entity<BillPromotion>()
                .HasOne(pm => pm.Promotion)
                .WithMany(m => m.BillPromotions)
                .HasForeignKey(pm => pm.PromotionID);
            SeenDingData(modelBuilder);


        }
        private void SeenDingData(ModelBuilder modelBuilder)
        {
            var roleData = new List<Roles>()
            {
                new Roles
                {
                    ID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

                    CreatedTime = DateTime.Now,
                    Status = EntityStatus.Active,
                    RoleName = "Admin",
                },
                new Roles
                {
                    ID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                    CreatedTime = DateTime.Now,
                    Status = EntityStatus.Active,
                    RoleName = "Client",
                },  new Roles
                {
                    ID = Guid.Parse("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                    CreatedTime = DateTime.Now,
                    Status = EntityStatus.Active,
                    RoleName = "Staff",
                },
            };
            modelBuilder.Entity<Roles>(b => { b.HasData(roleData); });
            var userData = new List<Users>()
            {
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTime.Now,
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
                    CreatedTime = DateTime.Now,
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
                    CreatedTime = DateTime.Now,
                    FullName = "Client",
                    Email = "client@gmail.com",
                    PassWord = Hash.Encrypt("client123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0334555555",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("25/12/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                },
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTime.Now,
                    FullName = "Nguyễn Văn Trọng",
                    Email = "vantrongvt1310@gmail.com",
                    PassWord = Hash.Encrypt("abc123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0334583920",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("13/10/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                },
                 new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTime.Now,
                    FullName = "Đặng Xuân Phong",
                    Email = "Phongdxph35748@fpt.edu.vn",
                    PassWord = Hash.Encrypt("abc123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0356400122",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("13/10/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                },
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTime.Now,
                    FullName = "Đặng Đức Cường",
                    Email = "cuongddpc07789@fpt.edu.vn",
                    PassWord = Hash.Encrypt("abc123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0879130050",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("13/10/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                },
                  new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTime.Now,
                    FullName = "Nguyễn Văn Trọng",
                    Email = "vantrongvt1310@gmail.com",
                    PassWord = Hash.Encrypt("abc123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0334583920",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("13/10/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                },
                 new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTime.Now,
                    FullName = "Đặng Xuân Phong",
                    Email = "Phongdxph35748@fpt.edu.vn",
                    PassWord = Hash.Encrypt("abc123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0356400122",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("13/10/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                },
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTime.Now,
                    FullName = "Đặng Đức Cường",
                    Email = "cuongddpc07789@fpt.edu.vn",
                    PassWord = Hash.Encrypt("abc123"),
                    Status = EntityStatus.Active,
                    PhoneNumber = "0879130050",
                    Adderss = "Ba Vi",
                    DateOrBriht= DateTime.Parse("13/10/2004"),
                    Images = "images.jpg",
                    Gender = "Nam",
                    RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                }
            };
            modelBuilder.Entity<Users>(b => { b.HasData(userData); });
         
         
         
            // Create new GUIDs
            var promotionCodeTet2024Id = Guid.NewGuid();
            var promotionCodeVIP2024Id = Guid.NewGuid();

            var promotionUsersId1 = Guid.NewGuid();
            var promotionUsersId2 = Guid.NewGuid();
            var promotionUsersPromotionId1 = Guid.NewGuid(); // Link to a promotion
            var promotionUsersPromotionId2 = Guid.NewGuid(); // Link to another promotion
            var userId1 = Guid.NewGuid(); // User 1 ID
            var userId2 = Guid.NewGuid(); // User 2 ID

            var promotionTypePercentageId = Guid.NewGuid();
            var promotionTypeFixedAmountId = Guid.NewGuid();
            var promotionTypeBuyOneGetOneId = Guid.NewGuid();

            var promotionTetId = Guid.NewGuid();
            var promotionVIPId = Guid.NewGuid();

            var promotionMovieId = Guid.NewGuid(); // Link to a promotion

            // Seed PromotionCode
            modelBuilder.Entity<PromotionCode>().HasData(new List<PromotionCode>
    {
        new PromotionCode
        {
            ID = promotionCodeTet2024Id,
            Code = "TET2024",
            StartDate = new DateTime(2024, 1, 1),
            EndDate = new DateTime(2024, 1, 31),
            MaxUsage = 100
        },
        new PromotionCode
        {
            ID = promotionCodeVIP2024Id,
            Code = "VIP2024",
            StartDate = new DateTime(2024, 2, 1),
            EndDate = new DateTime(2024, 12, 31),
            MaxUsage = 50
        }
    });

          


            // Seed PromotionType
            modelBuilder.Entity<PromotionType>().HasData(new List<PromotionType>
    {
        new PromotionType
        {
            ID = promotionTypePercentageId,
            Name = "Giảm giá phần trăm",
            Description = "Giảm giá theo phần trăm tổng hóa đơn"
        },
        new PromotionType
        {
            ID = promotionTypeFixedAmountId,
            Name = "Giảm giá cố định",
            Description = "Giảm giá một số tiền cụ thể trên hóa đơn"
        },
        new PromotionType
        {
            ID = promotionTypeBuyOneGetOneId,
            Name = "Mua 1 tặng 1",
            Description = "Khuyến mãi mua một sản phẩm, tặng kèm một sản phẩm khác"
        }
    });

            // Seed Promotion
            modelBuilder.Entity<Promotion>().HasData(new List<Promotion>
    {
        new Promotion
        {
            ID = promotionTetId,
            Name = "Khuyến mãi Tết Nguyên Đán",
            Description = "Giảm giá 20% cho tất cả khách hàng vào dịp Tết Nguyên Đán",
            DiscountAmount = 20,
            PromotionTypeID = promotionTypeFixedAmountId,
            StartDate = new DateTime(2024, 1, 10),
            EndDate = new DateTime(2024, 1, 31),
            IsActive = true,
            UserID = null,
            PromotionCodeID = promotionCodeTet2024Id
        },
        new Promotion
        {
            ID = promotionVIPId,
            Name = "Giảm giá khách hàng VIP",
            Description = "Giảm giá 30% cho khách hàng VIP",
            DiscountAmount = 30,
            PromotionTypeID = promotionTypePercentageId,
            StartDate = new DateTime(2024, 2, 1),
            EndDate = new DateTime(2024, 12, 31),
            IsActive = true,
            UserID = userId1,
            PromotionCodeID = promotionCodeVIP2024Id
        }
    });

            
        

            var languageData = new List<Language>()
             { new Language(){
                ID = Guid.NewGuid(),
                LanguageName = "en",
             },
             new Language()
             {
                 ID = Guid.NewGuid(),
                 LanguageName = "vi",
             },
             new Language()
             {
                 ID= Guid.NewGuid(),
                 LanguageName = "ja"
             }
            };
            modelBuilder.Entity<Language>(b => { b.HasData(languageData); });
            var directorData = new List<Director>()
            {
                new Director()
                {
                    ID = Guid.NewGuid(),
                    FullName = "Nguyễn Văn A",
                    Address = "Hà Nội",
                    Biography = "Có",
                    BirthDate = DateTime.Parse("10/10/2000"),
                    Gender = "Nam",
                    Images = "image1.jpg",
                    Nationality = "Ha Noi",
                    Status = EntityStatus.Active,
                },
                 new Director()
                {
                    ID = Guid.NewGuid(),
                    FullName = "Nguyễn Văn D",
                    Address = "Hà Nội",
                    Biography = "Có",
                    BirthDate = DateTime.Parse("10/10/2000"),
                    Gender = "Nam",
                    Images = "image1.jpg",
                    Nationality = "Ha Noi",
                    Status = EntityStatus.Active,
                },
                  new Director()
                {
                    ID = Guid.NewGuid(),
                    FullName = "Nguyễn Văn B",
                    Address = "Hà Nội",
                    Biography = "Có",
                    BirthDate = DateTime.Parse("10/10/2000"),
                    Gender = "Nam",
                    Images = "image1.jpg",
                    Nationality = "Ha Noi",
                    Status = EntityStatus.Locked,
                },
                   new Director()
                {
                    ID = Guid.NewGuid(),
                    FullName = "Nguyễn Văn C",
                    Address = "Hà Nội",
                    Biography = "Có",
                    BirthDate = DateTime.Parse("10/10/2000"),
                    Gender = "Nam",
                    Images = "image1.jpg",
                    Nationality = "Ha Noi",
                    Status = EntityStatus.Locked,
                }
            };
            modelBuilder.Entity<Director>(a => { a.HasData(directorData); });
            var genreData = new List<Genre>()
            {
                new Genre()
                {
                    ID = Guid.NewGuid(),
                    GenreName = "Kịch tính",

                },
                   new Genre()
                {
                    ID = Guid.NewGuid(),
                    GenreName = "Tình cảm",

                },
                      new Genre()
                {
                    ID = Guid.NewGuid(),
                    GenreName = "2D",

                },
                         new Genre()
                {
                    ID = Guid.NewGuid(),
                    GenreName = "Hoạt hình",

                },

            };
            modelBuilder.Entity<Genre>(x => { x.HasData(genreData); });
            var countryData = new List<Countrys>()
            {
                new Countrys()
                {
                    ID = Guid.NewGuid(),
                    CountryName = "Nhật Bản"
                },
                new Countrys()
                {
                    ID = Guid.NewGuid(),
                    CountryName = "Vương Quốc Anh"
                },
               new Countrys()
                {
                    ID = Guid.NewGuid(),
                    CountryName = "Trung Quốc"
                },
                new Countrys()
                {
                    ID = Guid.NewGuid(),
                    CountryName = "Việt Nam"
                },
            };
            modelBuilder.Entity<Countrys>(x => { x.HasData(countryData); });
		}
	}

};






