using NeonCinema_Application.DataTransferObject.ActorMoives;
using NeonCinema_Application.DataTransferObject.ActorMovies;
using NeonCinema_Application.DataTransferObject.Actors;
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
		public Task<HttpResponseMessage> Create(CreateMovieRequest request, CancellationToken cancellationToken);
		public Task<HttpResponseMessage> Update(UpdateMovieRequest request);
        public Task<MovieDTO> GetMovieById(Guid id);
        public Task<PaginationResponse<ActorDTO>> GetActor(ViewActorRequest request);
		public Task<HttpResponseMessage> CreateActorMovies(CreateActorMoviesRequest request);
        public Task<List<ActorMoviesDto>> GetActorsByFilmAsync(Guid moviesId, CancellationToken cancellationToken);
	}
}