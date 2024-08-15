using Bogus;
using Bogus.Hollywood;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Extention;
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
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Lenguage> Lenguages { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }
        public DbSet<MovieDetail> MoviesDetails { get; set; }
        public DbSet<Movies> Movies { get; set; }
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

            optionsBuilder.UseSqlServer("Data Source=vantrong\\SQLEXPRESS;Initial Catalog=NeonCinema;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //FakeData(modelBuilder);
        }
        protected void FakeData(ModelBuilder modelBuilder)
        {

            #region seendingdata
            var actorFaker = new Faker<Actor>("vi")
                .RuleFor(at => at.ActorID, x => Guid.NewGuid())
                .RuleFor(at => at.FullName, x => x.Name.FullName())
                .RuleFor(at => at.Address, x => x.Address.FullAddress())
                .RuleFor(at => at.StageName, x => x.Name.LastName())
                .RuleFor(at => at.Awards, x => x.Lorem.Sentence(400, 100))
                .RuleFor(at => at.Biography, x => x.Lorem.Sentence(400,100))
                .RuleFor(at => at.BirthDate, x => x.Date.Past(65, DateTime.Now.AddYears(-16)))
                .RuleFor(at => at.Images, x => x.Image.PicsumUrl(400, 300))
                .RuleFor(at => at.Nationality, x => x.Address.City());
            var actorFakers = actorFaker.Generate(20);
            modelBuilder.Entity<Actor>().HasData(actorFakers);
            //
            var directorFaker = new Faker<Director>("vi")
               .RuleFor(at => at.DirectorID, x => Guid.NewGuid())
               .RuleFor(at => at.FullName, x => x.Name.FullName())
               .RuleFor(at => at.Address, x => x.Address.FullAddress())
               .RuleFor(at => at.StageName, x => x.Name.LastName())
               .RuleFor(at => at.Awards, x => x.Lorem.Sentence(400,100))
               .RuleFor(at => at.Biography, x => x.Lorem.Sentence(400,100))
               .RuleFor(at => at.BirthDate, x => x.Date.Past(65, DateTime.Now.AddYears(-16)))
               .RuleFor(at => at.Images, x => x.Image.PicsumUrl(400, 300))
               .RuleFor(at => at.Nationality, x => x.Address.City());
            var directors = directorFaker.Generate(20);
            modelBuilder.Entity<Director>().HasData(directors);
            //
            var genreFaker = new Faker<Genre>("vi")
                 .RuleFor(at => at.GenreID, x => Guid.NewGuid())
               .RuleFor(at => at.GenreName, x => x.Internet.DomainName());
            var genres = genreFaker.Generate(50);
            modelBuilder.Entity<Genre>().HasData(genres);
            //
            List<string> langs = new List<string>
            {
                "VietNamese",
                "English",
                "Spanish",
                "French",
                "German",
                "Chinese",
                "Japanese",
                "Korean",
                "Russian",
                "Portuguese",
                "Italian",
                "Dutch",
                "Arabic",
                "Hindi"
            };
            var lenguageFaker = new Faker<Lenguage>("vi")
                .RuleFor(at => at.LenguageID, x => Guid.NewGuid())
              .RuleFor(at => at.LenguageName, x => x.PickRandom(langs));
            var lenguages = lenguageFaker.Generate(50);
            modelBuilder.Entity<Lenguage>().HasData(lenguages);
            //
            var movieTypeFaker = new Faker<MovieType>("vi")
               .RuleFor(at => at.MovieTypeID, x => Guid.NewGuid())
             .RuleFor(at => at.MovieTypeName, x => x.Internet.DomainName());
            var movieTypes = movieTypeFaker.Generate(50);
            modelBuilder.Entity<MovieType>().HasData(movieTypes);
            //

            var movieFaker = new Faker<Movies>("vi")
           .RuleFor(at => at.MovieID, x => Guid.NewGuid())
             .RuleFor(at => at.MovieName, x => x.Internet.DomainName())
             .RuleFor(at => at.Description, x => x.Lorem.Text())
             .RuleFor(at => at.Status, x => x.PickRandom(MovieStatus.Active));
            var movies = movieFaker.Generate(200);
            modelBuilder.Entity<Movies>().HasData(movies);

            //   var movieDetailFaker = new Faker<MovieDetail>("vi")
            //.RuleFor(at => at.MovieDetailID, x => Guid.NewGuid())
            //.RuleFor(at => at.AgeAllowed, x => x.Random.Int(15, 60))
            //.RuleFor(at => at.Duration, x => x.Random.Float(50, 120))
            //.RuleFor(at => at.StarTime, x => x.Date.Past(1))
            //.RuleFor(at => at.EndTime, x => x.Date.Soon(2))
            //.RuleFor(at => at.Images,  )


            // var movieDetail = movieDetailFaker.Generate(200);
            // modelBuilder.Entity<Genre>().HasData(movies);


            //var customer = new List<Customers>()
            //{
            //    new Customers()
            //    {
            //        CustomerID = Guid.NewGuid(),
            //        CustomerName = "Nguyen Van Trong",
            //        Email = "trongnvph35790@fpt.edu.vn",
            //        PassWord = Hash.Encrypt("123456789"),
            //        Images = new List<string>()
            //        {
            //            "image3.jpg","image4.jpg"
            //        },
            //        PhoneNumber = ("0334583920"),
            //        Sex = "Nam",
            //        DateOrBriht = DateTime.Parse("13-10-2004"),
            //        CreatedBy = Guid.NewGuid(),

            //    }
            //};
            //modelBuilder.Entity<Customers>(
            //        x=>x.HasData(customer)
            //    );
                #endregion
        }
    }

}


