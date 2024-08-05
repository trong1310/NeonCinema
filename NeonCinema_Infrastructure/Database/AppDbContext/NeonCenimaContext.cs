using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
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
        public DbSet<Cinema> Cinema { get; set; }
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

            optionsBuilder.UseSqlServer("Data Source=PHONGKEDAY2\\PHONGKE2004;Initial Catalog=NeonCinema;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

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
            var promotionTypeData = new List<PromotionType>
        {
            new PromotionType
            {
                PromotionTypeID = Guid.Parse("f20a48bc-c550-4c09-9fe0-0b24f2bec9f6"),
                PromotionName = "Khuyến mãi mùa hè",
                Status = EntityStatus.Active
            },
            new PromotionType
            {
                PromotionTypeID = Guid.Parse("a6c64cd9-f8ee-4465-a238-daa3426d87f9"),
                PromotionName = "Khuyến mãi mùa đông",
                Status = EntityStatus.Active
            }
        };

            var promotionData = new List<Promotion>
        {
            new Promotion
            {
                PromotionID = Guid.Parse("e20a48bc-c550-4c09-9fe0-0b24f2bec9f7"),
                PromotionCode = "SUMMER2024",
                Description = "Giảm giá 20% cho tất cả các sản phẩm trong mùa hè.",
                StarDate = DateTime.Parse("2024-06-01"),
                EndDate = DateTime.Parse("2024-08-31"),
                Quantity = 100,
                proviso = "Áp dụng cho hóa đơn trên 1 triệu đồng.",
                Discount = "20%",
                Status = EntityStatus.Active,
                PromotionTypeID = Guid.Parse("f20a48bc-c550-4c09-9fe0-0b24f2bec9f6")
            },
            new Promotion
            {
                PromotionID = Guid.Parse("b7a64cd9-f8ee-4465-a238-daa3426d87f8"),
                PromotionCode = "WINTER2024",
                Description = "Giảm giá 30% cho tất cả các sản phẩm trong mùa đông.",
                StarDate = DateTime.Parse("2024-12-01"),
                EndDate = DateTime.Parse("2025-02-28"),
                Quantity = 150,
                proviso = "Áp dụng cho hóa đơn trên 1.5 triệu đồng.",
                Discount = "30%",
                Status = EntityStatus.Active,
                PromotionTypeID = Guid.Parse("a6c64cd9-f8ee-4465-a238-daa3426d87f9")
            }
        };

            var promotionCustomerData = new List<PromotionCustomer>
        {
            new PromotionCustomer
            {
                PromotionId = Guid.Parse("e20a48bc-c550-4c09-9fe0-0b24f2bec9f7"),
                ID = Guid.Parse("1f64cd9f-f8ee-4465-a238-daa3426d87a1"),
                Status = EntityStatus.Active
            },
            new PromotionCustomer
            {
                PromotionId = Guid.Parse("b7a64cd9-f8ee-4465-a238-daa3426d87f8"),
                ID = Guid.Parse("2f64cd9f-f8ee-4465-a238-daa3426d87a2"),
                Status = EntityStatus.Active
            }
        };

            // Add data to your DbContext
            using (var context = new NeonCenimaContext())
            {
                context.PromotionTypes.AddRange(promotionTypeData);
                context.Promotion.AddRange(promotionData);
                context.PromotionCustomers.AddRange(promotionCustomerData);

                context.SaveChanges();
            }
            var billData = new List<Bill>
        {
            new Bill
            {
                BillID = Guid.NewGuid(),
                SoldDate = DateTime.Now,
                TotalMoney = 150.75m,
                Status = EntityStatus.Active
            },
            new Bill
            {
                BillID = Guid.NewGuid(),
                SoldDate = DateTime.Now.AddDays(-1),
                TotalMoney = 200.50m,
                Status = EntityStatus.Active
            }
        };
            modelBuilder.Entity<Bill>().HasData(billData);

            // BillDetail
            var billDetailData = new List<BillDetail>
        {
            new BillDetail
            {
                BillDetailID = Guid.NewGuid(),
                BillID = billData[0].BillID,
                CustomerID = Guid.NewGuid(),
                TicketID = Guid.NewGuid(),
                PaymentID = Guid.NewGuid(),
                ServiceOderID = Guid.NewGuid(),
                EmployeeID = Guid.NewGuid(),
                PromotionID = Guid.NewGuid(),
                Price = 50.00m,
                NumberOfProduct = 2,
                Status = EntityStatus.Active
            }
        };
            modelBuilder.Entity<BillDetail>().HasData(billDetailData);

            // Cenima
            var cenimaData = new List<Cinema>
        {
            new Cinema
            {
                CinemaID = Guid.NewGuid(),
                Name = "CineWorld",
                Location = "123 Cinema Street",
                PhoneNumber = "123-456-7890",
                WebSite = "www.cineworld.com",
                OpeningHours = "09:00 AM",
                ClosingHours = "11:00 PM",
                RoomNumber = 5
            }
        };
            modelBuilder.Entity<Cinema>().HasData(cenimaData);

            // Customers
            var customerData = new List<Customers>
        {
            new Customers
            {
                CustomerID = Guid.NewGuid(),
                CustomerName = "John Doe",
                PassWord = "password123",
                PhoneNumber = "987-654-3210",
                Email = "john.doe@example.com",
                Sex = "Male",
                Images = new List<string> { "image1.jpg", "image2.jpg" },
                DateOrBriht = new DateTime(1990, 1, 1),
                ConfirmCode = "ABC123"
            }
        };
            modelBuilder.Entity<Customers>().HasData(customerData);

            // Employees
            var employeeData = new List<Employees>
        {
            new Employees
            {
                EmployeesID = Guid.NewGuid(),
                EmployeesName = "Jane Smith",
                PassWord = "password456",
                PhoneNumber = "555-555-5555",
                Email = "jane.smith@example.com",
                Sex = "Female",
                Images = new List<string> { "profile1.jpg" },
                DateOrBriht = new DateTime(1985, 5, 15),
                Position = "Manager",
                CreateDate = DateTime.Now
            }
        };
            modelBuilder.Entity<Employees>().HasData(employeeData);

            // MemberShip
            var memberShipData = new List<MemberShip>
        {
            new MemberShip
            {
                MemberShipID = Guid.NewGuid(),
                Rank = "Gold",
                Endow = "10% discount",
                CustomerID = customerData[0].CustomerID,
                Status = EntityStatus.Active,
                StarDate = DateTime.Now.AddMonths(-6)
            }
        };
            modelBuilder.Entity<MemberShip>().HasData(memberShipData);

            // PaymentMethod
            var paymentMethodData = new List<PaymentMethod>
        {
            new PaymentMethod
            {
                PaymentID = Guid.NewGuid(),
                Name = "Credit Card",
                QRCode = null,
                Status = EntityStatus.Active
            }
        };
            modelBuilder.Entity<PaymentMethod>().HasData(paymentMethodData);

            // Point
            var pointData = new List<Point>
        {
            new Point
            {
                PointID = Guid.NewGuid(),
                TotalPoint = 500,
                DateEarned = DateTime.Now.AddMonths(-1),
                CustomerID = customerData[0].CustomerID
            }
        };
            modelBuilder.Entity<Point>().HasData(pointData);

            // Rating
            var ratingData = new List<Rating>
        {
            new Rating
            {
                RatingID = Guid.NewGuid(),
                Ratings = 4,
                Comment = "Great movie!",
                RatingDate = DateTime.Now,
                Status = EntityStatus.Active,
                TicketID = Guid.NewGuid(),
                CustomerID = customerData[0].CustomerID
            }
        };
            modelBuilder.Entity<Rating>().HasData(ratingData);

            // Room
            var roomData = new List<Room>
        {
            new Room
            {
                RoomID = Guid.NewGuid(),
                Name = "Room 1",
                SeatingCapacity = 100,
                CinemaID = cenimaData[0].CinemaID
            }
        };
            modelBuilder.Entity<Room>().HasData(roomData);

            // Screening
            var screeningData = new List<Screening>
        {
            new Screening
            {
                ScreeningID = Guid.NewGuid(),
                StarTime = DateTime.Now.AddHours(1),
                EndTime = DateTime.Now.AddHours(3),
                Price = 12.50m,
                Status = EntityStatus.Active,
                ScreeningDate = DateTime.Now.Date,
                MovieID = Guid.NewGuid(),
                RoomID = roomData[0].RoomID
            }
        };
            modelBuilder.Entity<Screening>().HasData(screeningData);

            // Seat
            var seatData = new List<Seat>
        {
            new Seat
            {
                SeatID = Guid.NewGuid(),
                SeatNumber = "A1",
                SeatTypeID = Guid.NewGuid(),
                RoomID = roomData[0].RoomID
            }
        };
            modelBuilder.Entity<Seat>().HasData(seatData);

            // SeatType
            var seatTypeData = new List<SeatType>
        {
            new SeatType
            {
                SeatTypeID = Guid.NewGuid(),
                SeatTypeName = "Standard",
                Price = 10.00m
            }
        };
            modelBuilder.Entity<SeatType>().HasData(seatTypeData);

            // Service
            var serviceData = new List<Service>
        {
            new Service
            {
                ServiceID = Guid.NewGuid(),
                ServiceName = "Popcorn",
                Price = 5.00m,
                Status = EntityStatus.Active,
                Description = "Large popcorn"
            }
        };
            modelBuilder.Entity<Service>().HasData(serviceData);

            // ServiceOder
            var serviceOderData = new List<ServiceOder>
        {
            new ServiceOder
            {
                ServiceOderID = Guid.NewGuid(),
                Quantity = 2,
                TotalPrice = 10.00m,
                ServiceID = serviceData[0].ServiceID
            }
        };
            modelBuilder.Entity<ServiceOder>().HasData(serviceOderData);

            // ShiftChange
            var shiftChangeData = new List<ShiftChange>
        {
            new ShiftChange
            {
                ShiftChangeID = Guid.NewGuid(),
                ShiftName = "Morning",
                NewShift = "Afternoon",
                RequetDate = DateTime.Now,
                Status = EntityStatus.Active,
                WorkShiftID = Guid.NewGuid()
            }
        };
            modelBuilder.Entity<ShiftChange>().HasData(shiftChangeData);

            // Ticket
            var ticketData = new List<Ticket>
        {
            new Ticket
            {
                TicketID = Guid.NewGuid(),
                Price = 12.50m,
                BarCode = "ABC123456",
                Status = EntityStatus.Active,
                PurchaseDate = DateTime.Now,
                CustomerID = customerData[0].CustomerID,
                SeatID = seatData[0].SeatID,
                ScreeningID = screeningData[0].ScreeningID
            }
        };
            modelBuilder.Entity<Ticket>().HasData(ticketData);

            // WorkShift
            var workShiftData = new List<WorkShift>
        {
            new WorkShift
            {
                WorkShiftID = Guid.NewGuid(),
                WorkDate = DateTime.Now.Date,
                TimeStar = DateTime.Now.AddHours(-4),
                TimeEnd = DateTime.Now,
                Status = EntityStatus.Active,
                EmployeesID = employeeData[0].EmployeesID
            }
        };
            modelBuilder.Entity<WorkShift>().HasData(workShiftData);
        }
    }
    #endregion
}
    

