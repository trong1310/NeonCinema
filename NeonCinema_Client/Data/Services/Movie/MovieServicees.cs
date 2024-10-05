//using AutoMapper;
//using Bogus.Hollywood.DataSets;
//using Microsoft.EntityFrameworkCore;
//using NeonCinema_Application.DataTransferObject.Countrys;
//using NeonCinema_Application.DataTransferObject.Directors;
//using NeonCinema_Application.DataTransferObject.Genre;
//using NeonCinema_Application.DataTransferObject.Language;
//using NeonCinema_Application.DataTransferObject.Movie;
//using NeonCinema_Client.Data.IServices.IMoviesServices;
//using NeonCinema_Client.Data.IServices.Movie;
//using NeonCinema_Infrastructure.Database.AppDbContext;
//using NeonCinema_Domain.Database.Entities;
//using Movies = NeonCinema_Domain.Database.Entities.Movies;
//using NeonCinema_Domain.Enum;

//namespace NeonCinema_Client.Data.Services.Movie
//{
//    public class MovieServicees : IMovieServicee
//    {
//        private readonly NeonCinemasContext _context;
//        private readonly IMapper _mapper;

//        public MovieServicees(NeonCinemasContext context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }
//        public async Task<bool> CreateMovieAsync(CreateMovieRequest request, CancellationToken cancellationToken)
//        {
//            var countryExists = await _context.Country.AnyAsync(c => c.ID == request.CountryID, cancellationToken);
//            if (!countryExists)
//            {
//                throw new Exception("Invalid CountryID.");
//            }

//            var movie = new Movies
//            {
//                ID = Guid.NewGuid(),
//                Duration = request.Duration,
//                Name = request.Name,
//                Trailer = request.Trailer,
//                Description = request.Description,
//                StarTime = request.StarTime,
//                AgeAllowed = request.AgeAllowed,
//                Status = MovieStatus.Comingsoon,
//                GenreID = request.GenreID,
//                LenguageID = request.LenguageID,
//                CountryID = request.CountryID,
//                DirectorID = request.DirectorID,
//                CreatedTime = DateTime.Now,
//            };

//            // Save the image to wwwroot/images/movies and store its path
//            if (request.Images != null)
//            {
//                var imageFolderPath = Path.Combine("wwwroot", "images", "movies");
//                var imagePath = Path.Combine(imageFolderPath, request.Images.FileName);

//                // Save the image to the folder
//                using (var stream = new FileStream(imagePath, FileMode.Create))
//                {
//                    await request.Images.CopyToAsync(stream);
//                }

//                // Store the relative image path in the database (for access via URL)
//                movie.Images = $"/images/movies/{request.Images.FileName}";
//            }

//            await _context.Movies.AddAsync(movie, cancellationToken);
//            var saved = await _context.SaveChangesAsync(cancellationToken);

//            return saved > 0;
//        }

//        public async Task<List<CountryDTO>> GetAllCountriesAsync(CancellationToken cancellationToken)
//        {
//            return await _context.Country
//            .Select(c => new CountryDTO { ID = c.ID, CountryName = c.CountryName })
//            .ToListAsync(cancellationToken);
//        }

//        public async Task<List<DirectorDTO>> GetAllDirectorsAsync(CancellationToken cancellationToken)
//        {
//            return await _context.Directors
//            .Select(d => new DirectorDTO { ID = d.ID, FullName = d.FullName })
//            .ToListAsync(cancellationToken);
//        }

//        public async Task<List<GenreDTO>> GetAllGenresAsync(CancellationToken cancellationToken)
//        {
//            return await _context.Genres
//             .Select(g => new GenreDTO { ID = g.ID, GenreName = g.GenreName })
//             .ToListAsync(cancellationToken);
//        }

//        public async Task<List<LanguageDTO>> GetAllLanguagesAsync(CancellationToken cancellationToken)
//        {
//            return await _context.Lenguages
//           .Select(l => new LanguageDTO { ID = l.ID, LanguageName = l.LanguageName })
//           .ToListAsync(cancellationToken);
//        }

//        public async Task<List<MovieDTO>> GetAllMoviesAsync(ViewMovieRequest request, CancellationToken cancellationToken)
//        {
//            // Gọi method GetAll từ MovieRepositories
//            return await _context.Movies
//                .Include(m => m.Genre)
//                .Include(m => m.Lenguage)
//                .Include(m => m.Countrys)
//                .Include(m => m.Director)
//                .AsNoTracking()
//                .Select(m => _mapper.Map<MovieDTO>(m))
//                .ToListAsync(cancellationToken);
//        }

//        public async Task<MovieDTO> GetMovieByIdAsync(Guid id)
//        {
//            var movie = await _context.Movies
//        .Include(m => m.Genre)
//        .Include(m => m.Lenguage)
//        .Include(m => m.Countrys)
//        .Include(m => m.Director)
//        .AsNoTracking()
//        .FirstOrDefaultAsync(m => m.ID == id);

//            return _mapper.Map<MovieDTO>(movie);
//        }

//        public async Task<bool> UpdateMovieAsync(UpdateMovieRequest request, CancellationToken cancellationToken)
//        {
//            var movie = await _context.Movies.FindAsync(new object[] { request.ID }, cancellationToken);
//            if (movie == null)
//            {
//                return false; // Phim không tồn tại
//            }

//            // Cập nhật các thuộc tính
//            movie.Name = request.Name;
//            movie.Description = request.Description;
//            movie.Duration = request.Duration;
//            movie.StarTime = request.StarTime;
//            movie.GenreID = request.GenreID;
//            movie.LenguageID = request.LenguageID;
//            movie.CountryID = request.CountryID;
//            movie.DirectorID = request.DirectorID;

//            // Cập nhật hình ảnh nếu có
//            if (request.Images != null)
//            {
//                // Xử lý lưu hình ảnh ở đây (giống như trong phương thức CreateMovieAsync)
//                movie.Images = $"/images/movies/{request.Images.FileName}";
//            }

//            var result = await _context.SaveChangesAsync(cancellationToken);
//            return result > 0;
//        }
//    }
//}
