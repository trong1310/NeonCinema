//using NeonCinema_Application.DataTransferObject.Countrys;
//using NeonCinema_Application.DataTransferObject.Directors;
//using NeonCinema_Application.DataTransferObject.Genre;
//using NeonCinema_Application.DataTransferObject.Language;
//using NeonCinema_Application.DataTransferObject.Movie;

//namespace NeonCinema_Client.Data.IServices.Movie
//{
//    public interface IMovieServicee
//    {
//        Task<List<MovieDTO>> GetAllMoviesAsync(ViewMovieRequest request, CancellationToken cancellationToken);
//        Task<bool> CreateMovieAsync(CreateMovieRequest request, CancellationToken cancellationToken);
//        Task<List<GenreDTO>> GetAllGenresAsync(CancellationToken cancellationToken);
//        Task<List<LanguageDTO>> GetAllLanguagesAsync(CancellationToken cancellationToken);
//        Task<List<CountryDTO>> GetAllCountriesAsync(CancellationToken cancellationToken);
//        Task<List<DirectorDTO>> GetAllDirectorsAsync(CancellationToken cancellationToken);
//        Task<MovieDTO> GetMovieByIdAsync(Guid id);
//        Task<bool> UpdateMovieAsync(UpdateMovieRequest request, CancellationToken cancellationToken);
//    }
//}
