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
            optionsBuilder.UseSqlServer("Server=MRG;Database=NeonCenima;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           FakeData(modelBuilder);
        }
        private void FakeData(ModelBuilder modelBuilder)
        {
            #region fakedata
            var actorData = new List<Actor>()
            {
                new Actor{ActorID =Guid.Parse( "f20a48bc-c550-4c09-9fe0-0b24f2bec9f6"),
                    FullName = "Nguyễn Quang Dũng",
                    StageName ="Nguyễn Quang Dũng",
                    BirthDate = DateTime.Parse("12-1-1978"),
                    Address = " huyện Chợ Mới, tỉnh An Giang",
                    Awards = "Bằng khen Văn học nghệ thuật TP. Hồ Chí Minh, Biên kịch phim truyện nhựa xuất sắc nhất",
                    Biography = "Nguyễn Quang Dũng, đạo diễn và nhà sản xuất nổi tiếng, xuất thân trong một gia đình" +
                    " nghệ thuật có cha là nhà văn Nguyễn Quang Sáng. Từ khi còn nhỏ," 
                  ,
                    Images = new List<string>()
                    {
                        "image1.jpg","image2.jpg"
                    },
                    Nationality = "Việt Nam"
                },
                 new Actor{ActorID =Guid.Parse( "a6c64cd9-f8ee-4465-a238-daa3426d87f9"),
                    FullName = "Vũ Ngọc Đãng",
                    StageName ="Vũ Ngọc Đãng",
                    BirthDate = DateTime.Parse("10-10-1974"),
                    Address = "Thành phố Hồ Chí Minh",
                    Awards = "giải nhì Cuộc thi phim ngắn toàn quốc, Bông sen bạc Liên hoan phim toàn quốc lần thứ 14," ,
                    
                    Biography = "Vũ Ngọc Đãng là đạo diễn, nhà biên kịch, nhà sản xuất phim nổi tiếng. Anh tốt nghiệp thủ khoa Đạo",
                    Images = new List<string>()
                    {
                        "image1.jpg","image2.jpg"
                    },
                    Nationality = "Việt Nam"
                }
            };
            modelBuilder.Entity<Actor>(x => { x.HasData(actorData); });
            var direcTorData = new List<Director>()
            {
                new Director{DirectorID =Guid.Parse( "6b174569-9f4b-46d1-905c-15fbd33dc271"),
                    FullName = "Nguyễn Quang Dũng",
                    StageName ="Nguyễn Quang Dũng",
                    BirthDate = DateTime.Parse("12-11-1978"),
                    Address = " huyện Chợ Mới, tỉnh An Giang",
                    Awards = "Bằng khen Văn học nghệ thuật TP. Hồ Chí Minh, Biên kịch phim truyện nhựa xuất sắc nhất",
                    Biography = "Nguyễn Quang Dũng, đạo diễn và nhà sản xuất nổi tiếng, xuất thân trong một gia đình" 
                    ,
                    Images = new List<string>()
                    {
                        "image1.jpg","image2.jpg"
                    },
                    Nationality = "Việt Nam"
                },
                 new Director{DirectorID =Guid.Parse( "4f029623-3495-42fd-88ec-fc16e624abec"),
                    FullName = "Vũ Ngọc Đãng",
                    StageName ="Vũ Ngọc Đãng",
                    BirthDate = DateTime.Parse("4-4-1974"),
                    Address = "Thành phố Hồ Chí Minh",
                    Awards = "giải nhì Cuộc thi phim ngắn toàn quốc, Bông sen bạc Liên hoan phim toàn quốc lần thứ 14," +
                    " Đạo diễn xuất sắc Liên hoan phim Việt Nam 2011 và 2017," 
                  ,
                    Biography = "Vũ Ngọc Đãng là đạo diễn, nhà biên kịch, nhà sản xuất phim nổi tiếng. Anh tốt nghiệp thủ khoa Đạo" +
                    " diễn của Trường Sân khấu – Điện ảnh",
                    Images = new List<string>()
                    {
                        "image1.jpg","image2.jpg"
                    },
                    Nationality = "Việt Nam"
                }
            };
            modelBuilder.Entity<Director>(x => { x.HasData(direcTorData); });
            var genreData = new List<Genre>()
            {
                new Genre()
                {
                    GenreID = Guid.Parse("b954a76c-08c0-4399-8a7a-1556029b1d62"),
                    GenreName = "Phim Hành Động",
                },
                new Genre()
                {
                    GenreID = Guid.Parse("36c7532c-775e-4ad0-a524-1a99f6cb7edc"),
                    GenreName = "Kinh Dị",
                },
                new Genre()
                {
                    GenreID = Guid.Parse("975c468d-89db-497d-98d7-138798731b49"),
                    GenreName = "Phim Hoạt Hình",
                },
                new Genre()
                {
                    GenreID = Guid.Parse("47b628b5-2389-4eda-9b2a-0eafa2832b8b"),
                    GenreName = "Phim Tình Cảm",
                }
            };
            modelBuilder.Entity<Genre>(x => { x.HasData(genreData); });
            var lenguageData = new List<Lenguage>()
            {
                new Lenguage()
                {
                    LenguageID = Guid.Parse("b954a76c-08c0-4399-8a7a-1556029b1d62"),
                    LenguageName = "Tiếng Anh",
                },
                new Lenguage()
                {
                    LenguageID = Guid.Parse("36c7532c-775e-4ad0-a524-1a99f6cb7edc"),
                    LenguageName = "Tiếng Việt",
                },
                new Lenguage()
                {
                    LenguageID = Guid.Parse("975c468d-89db-497d-98d7-138798731b49"),
                    LenguageName = "Thái Lan",
                },
                new Lenguage()
                {
                    LenguageID = Guid.Parse("47b628b5-2389-4eda-9b2a-0eafa2832b8b"),
                    LenguageName = "Hàn Quốc",
                }
            };
            modelBuilder.Entity<Lenguage>(x => { x.HasData(lenguageData); });
            var movieTypeData = new List<MovieType>()
            {
                new MovieType()
                {
                    MovieTypeID = Guid.Parse("b954a76c-08c0-4399-8a7a-1556029b1d62"),
                    MovieTypeName = "Phim 2D",
                },
                new MovieType()
                {
                    MovieTypeID = Guid.Parse("36c7532c-775e-4ad0-a524-1a99f6cb7edc"),
                    MovieTypeName = "Phim 3D",
                },
                new MovieType()
                {
                    MovieTypeID = Guid.Parse("975c468d-89db-497d-98d7-138798731b49"),
                    MovieTypeName = "Phim VietSub",
                },
               
            };
            modelBuilder.Entity<MovieType>(x => { x.HasData(movieTypeData); });

            #endregion
        }
    }
}
