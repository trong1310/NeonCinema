using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;

namespace NeonCinema_Client.Data.IServices.IMoviesServices
{
    public interface IMovieservices
    {
        public Task<List<MovieDTO>> GetAllMovies();
        public Task<List<GenreDTO>> GetAllGenre();
        public Task<List<CountryDTO>> GetAllCountry();
        public Task<List<DirectorDTO>> GetAllDirector();
        public Task<List<LanguageDTO>> GetAllLanguage();
        public Task<bool> CreateMovie(CreateMovieRequest input);
        public Task<List<MovieDTO>> FilMovie(List<MovieDTO> lst,
         Func<MovieDTO, bool> dk1 = null,
         Func<MovieDTO, bool> dk2 = null,
         Func<MovieDTO, bool> dk3 = null,
         Func<MovieDTO, bool> dk4 = null);
    }
}
