using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_Client.Data.IServices.IMoviesServices
{
    public interface IMovieservices
    {
        public Task<PaginationResponse<MovieDTO>> GetAllMovies(ViewMovieRequest request);
		public Task<List<GenreDTO>> GetAllGenre();
        public Task<List<CountryDTO>> GetAllCountry();
        public Task<List<DirectorDTO>> GetAllDirector();
        public Task<List<LanguageDTO>> GetAllLanguage();
        public Task<HttpResponseMessage> CreateMovie(CreateMovieRequest request);
        public Task<HttpResponseMessage> Update(UpdateMovieRequest request);
        public Task<MovieDTO> GetMovieById(Guid id);
    }
}