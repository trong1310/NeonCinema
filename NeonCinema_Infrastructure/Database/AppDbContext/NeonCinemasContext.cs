﻿using Bogus;
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
        public DbSet<FileUpload> FileUploads { get; set; }

        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=vantrong\\SQLEXPRESS;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");

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
            };
            modelBuilder.Entity<Users>(b => { b.HasData(userData); });


            var movies = new List<Movies>
{
                new Movies {
                ID = Guid.Parse("4e9a5b9f-44f3-4a68-897c-0e92f8831e8a"),
                Duration = 120,

                Name = "Inception",
                Description = "A thief who steals corporate secrets using dream-sharing technology.",
                StarTime =  DateTime.Parse("10/10/2000"),
                Trailer = "inception_trailer.mp4",
                AgeAllowed = 13,
                Images ="flims2.jpg",
                Status = MovieStatus.Active,
                GenreID = Guid.Parse("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"),
                LenguageID = Guid.Parse("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"),
                CountryID = Guid.Parse("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"),
                DirectorID = Guid.Parse("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de")
                },
                new Movies {
                    ID = Guid.NewGuid(),
                    Duration = 100,
                    Name = "Nghề siêu dễ",
                    Description = "Câu chuyện này tập trung vào cuộc sống sau về hưu của một cảnh sát ở một xóm nhỏ của Sài Gòn. Dù đã rời khỏi ngành công an, tinh thần đoàn kết và lòng yêu nghề của chú cảnh sát vẫn rạng ngời. Trong một thời gian dài sống tại khu vực này, chú quyết định hợp tác với những thanh niên có hoàn cảnh và tính cách cá biệt để thực hiện một phi vụ điều tra bí ẩn.\r\n\r\nCuộc hợp tác bất ngờ này không chỉ kéo chú cảnh sát trở lại cuộc sống căng thẳng và hối hả của việc làm cảnh sát, mà còn khiến cho cuộc sống của họ trở nên rối ren và hài hước. Họ quyết định mua lại một quán cơm tấm tại xóm nhỏ để che mắt tội phạm và làm nơi tập trung thực hiện các hoạt động điều tra.\r\n\r\nKhông lâu sau, quán cơm tấm của họ trở nên nổi tiếng trong khu vực với những dĩa cơm thơm ngon và phục vụ tận tâm. Điều này không chỉ thu hút sự quan tâm của người dân trong khu vực mà còn của những khách hàng xa xôi. Sự thành công của quán cơm tấm bắt đầu tạo ra những trở ngại cho phi vụ điều tra của họ, và họ phải đối mặt với nhiều tình huống dở khóc dở cười trong quá trình điều tra.",
                    StarTime =  DateTime.Parse("10/10/2024"),
                    Trailer = "inception_trailer.mp4",
                    AgeAllowed = 18,
                    Images = "flims1.jpg",
                    Status = MovieStatus.Active,
                    GenreID = Guid.Parse("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"),
                    LenguageID = Guid.Parse("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"),
                    CountryID = Guid.Parse("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"),
                    DirectorID = Guid.Parse("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de")
                },
                  new Movies {
                    ID = Guid.NewGuid(),
                    Duration = 100,
                    Name = "Nghề siêu dễ",
                    Description = "Câu chuyện này tập trung vào cuộc sống sau về hưu của một cảnh sát ở một xóm nhỏ của Sài Gòn. Dù đã rời khỏi ngành công an, tinh thần đoàn kết và lòng yêu nghề của chú cảnh sát vẫn rạng ngời. Trong một thời gian dài sống tại khu vực này, chú quyết định hợp tác với những thanh niên có hoàn cảnh và tính cách cá biệt để thực hiện một phi vụ điều tra bí ẩn.\r\n\r\nCuộc hợp tác bất ngờ này không chỉ kéo chú cảnh sát trở lại cuộc sống căng thẳng và hối hả của việc làm cảnh sát, mà còn khiến cho cuộc sống của họ trở nên rối ren và hài hước. Họ quyết định mua lại một quán cơm tấm tại xóm nhỏ để che mắt tội phạm và làm nơi tập trung thực hiện các hoạt động điều tra.\r\n\r\nKhông lâu sau, quán cơm tấm của họ trở nên nổi tiếng trong khu vực với những dĩa cơm thơm ngon và phục vụ tận tâm. Điều này không chỉ thu hút sự quan tâm của người dân trong khu vực mà còn của những khách hàng xa xôi. Sự thành công của quán cơm tấm bắt đầu tạo ra những trở ngại cho phi vụ điều tra của họ, và họ phải đối mặt với nhiều tình huống dở khóc dở cười trong quá trình điều tra.",
                    StarTime =  DateTime.Parse("10/10/2024"),
                    Trailer = "inception_trailer.mp4",
                    AgeAllowed = 18,
                    Images = "flims2.jpg",
                    Status= MovieStatus.Comingsoon,
                    GenreID = Guid.Parse("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"),
                    LenguageID = Guid.Parse("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"),
                    CountryID = Guid.Parse("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"),
                    DirectorID = Guid.Parse("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de")
                },
                    new Movies {
                    ID = Guid.NewGuid(),
                    Duration = 100,
                    Name = "Mến gái miền Tây",
                     Description = "Bộ phim tương tác với đề tài giới tính thứ 3 qua cuộc sống của Mến và Nhớ. Tại miền Tây sông nước, sự kỳ thị và áp lực xã hội đặt lên họ trở thành hình mẫu tiêu biểu cho câu chuyện về sự đấu tranh vì tình yêu và sự chấp nhận. Cặp đôi Mến - Nhớ đã phải vượt qua những khó khăn và thách thức đặt ra bởi xã hội và cuộc sống hàng ngày để tìm kiếm hạnh phúc của mình.\r\n\r\nTuy nhiên, bi kịch không ngờ đến khi Nhớ bắt đầu từ bỏ, dẫn đến việc anh bắt đầu du nhập vào những mối quan hệ mới với những cô gái khác... Cuộc hành trình của họ đánh dấu một câu chuyện đầy bi thương về tình yêu và sự thay đổi trong một xã hội định kiến.",
                    StarTime =  DateTime.Parse("10/10/2024"),
                    Trailer = "inception_trailer.mp4",
                    AgeAllowed = 18,
                    Images = "flims3.jpg",
                    Status = MovieStatus.Active,
                    GenreID = Guid.Parse("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"),
                    LenguageID = Guid.Parse("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"),
                    CountryID = Guid.Parse("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"),
                    DirectorID = Guid.Parse("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de")
                },
                                        new Movies {
                    ID = Guid.NewGuid(),
                    Duration = 100,
                    Name = "Mến gái miền Tây",
                     Description = "Bộ phim tương tác với đề tài giới tính thứ 3 qua cuộc sống của Mến và Nhớ. Tại miền Tây sông nước, sự kỳ thị và áp lực xã hội đặt lên họ trở thành hình mẫu tiêu biểu cho câu chuyện về sự đấu tranh vì tình yêu và sự chấp nhận. Cặp đôi Mến - Nhớ đã phải vượt qua những khó khăn và thách thức đặt ra bởi xã hội và cuộc sống hàng ngày để tìm kiếm hạnh phúc của mình.\r\n\r\nTuy nhiên, bi kịch không ngờ đến khi Nhớ bắt đầu từ bỏ, dẫn đến việc anh bắt đầu du nhập vào những mối quan hệ mới với những cô gái khác... Cuộc hành trình của họ đánh dấu một câu chuyện đầy bi thương về tình yêu và sự thay đổi trong một xã hội định kiến.",
                    StarTime =  DateTime.Parse("10/10/2024"),
                    Trailer = "inception_trailer.mp4",
                    AgeAllowed = 18,
                    Images = "flims3.jpg",
                    Status = MovieStatus.Active,
                    GenreID = Guid.Parse("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"),
                    LenguageID = Guid.Parse("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"),
                    CountryID = Guid.Parse("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"),
                    DirectorID = Guid.Parse("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de")
                },
                    new Movies {
                    ID = Guid.NewGuid(),
                    Duration = 100,
                    Name = "Mến gái miền Tây",
                     Description = "Bộ phim tương tác với đề tài giới tính thứ 3 qua cuộc sống của Mến và Nhớ. Tại miền Tây sông nước, sự kỳ thị và áp lực xã hội đặt lên họ trở thành hình mẫu tiêu biểu cho câu chuyện về sự đấu tranh vì tình yêu và sự chấp nhận. Cặp đôi Mến - Nhớ đã phải vượt qua những khó khăn và thách thức đặt ra bởi xã hội và cuộc sống hàng ngày để tìm kiếm hạnh phúc của mình.\r\n\r\nTuy nhiên, bi kịch không ngờ đến khi Nhớ bắt đầu từ bỏ, dẫn đến việc anh bắt đầu du nhập vào những mối quan hệ mới với những cô gái khác... Cuộc hành trình của họ đánh dấu một câu chuyện đầy bi thương về tình yêu và sự thay đổi trong một xã hội định kiến.",
                    StarTime =  DateTime.Parse("10/10/2024"),
                    Trailer = "inception_trailer.mp4",
                    AgeAllowed = 18,
                    Images = "flims3.jpg",
                    Status = MovieStatus.Comingsoon,
                    GenreID = Guid.Parse("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"),
                    LenguageID = Guid.Parse("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"),
                    CountryID = Guid.Parse("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"),
                    DirectorID = Guid.Parse("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de")
                },
            };
        }


    }

    // fakedata vào đây
}




