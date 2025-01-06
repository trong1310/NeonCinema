using Bogus.Hollywood.DataSets;
using Bogus.Hollywood.Models;
using NeonCinema_Application.DataTransferObject.ActorMoives;
using NeonCinema_Application.DataTransferObject.ActorMovies;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.IMoviesServices;
using NeonCinema_Domain.Database.Entities;
using System.Text;
using System.Text.Json;

namespace NeonCinema_Client.Services.MoivesService
{
	public class MoviesServices : IMovieservices
    {

        private readonly HttpClient _httpClient;

        public MoviesServices()
        {
            _httpClient = new HttpClient();
        }
		public async Task<HttpResponseMessage> Create(CreateMovieRequest request, CancellationToken cancellationToken)
        {
            
            try
            {
                var result = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Movie/Create", request,cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Có lỗi : " + ex.Message)
                };

            }

        }
		public async Task<HttpResponseMessage> CreateActor(CreateActorRequest request)
		{
			var respones = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Actor/createspeed", request);
			return respones;
		}
		public async Task<PaginationResponse<ActorDTO>> GetActor(ViewActorRequest request)
        {
            var respones = await _httpClient.GetFromJsonAsync<PaginationResponse<ActorDTO>>("https://localhost:7211/api/Actor/getactor");
            return respones;
        }
        public async Task<List<GenreDTO>> GetAllGenre()
        {
            var lst = await _httpClient.GetFromJsonAsync<List<GenreDTO>>("https://localhost:7211/api/Genre/get-all-genre");
            return lst;
        }

        public async Task<List<CountryDTO>> GetAllCountry()
        {
            var lst = await _httpClient.GetFromJsonAsync<List<CountryDTO>>("https://localhost:7211/api/Country");
            return lst;
        }

        public async Task<List<LanguageDTO>> GetAllLanguage()
        {
            var lst = await _httpClient.GetFromJsonAsync<List<LanguageDTO>>("https://localhost:7211/api/Language/get-all");
            return lst;
        }

        public async Task<List<DirectorDTO>> GetAllDirector()
        {
            var lst = await _httpClient.GetFromJsonAsync<List<DirectorDTO>>("https://localhost:7211/api/Director/Get-All");
            return lst;
        }

        public async Task<PaginationResponse<MovieDTO>> GetAllMovies(ViewMovieRequest request)
        {
            try
            {
                var results = await _httpClient.GetFromJsonAsync<PaginationResponse<MovieDTO>>($"https://localhost:7211/api/Movie/GetAll?PageNumber={request.PageNumber}&PageSize={request.PageSize}");
                return results;
            }
            catch (Exception ex) 
            {
                throw new Exception("co loi xay ra : " + ex.Message);
            }
        }

		public async Task<HttpResponseMessage> Update(UpdateMovieRequest request)
        {
            var respones = await _httpClient.PutAsJsonAsync("https://localhost:7211/api/Movie/Update", request);
            return respones;
        }

        public async Task<MovieDTO> GetMovieById(Guid id)
        {
            var respones = await _httpClient.GetFromJsonAsync<MovieDTO>($"https://localhost:7211/api/Movie/GetById?id={id}");
            return respones;
        }

		public async Task<List<ActorMoviesDto>> GetActorsByFilmAsync(Guid moviesId, CancellationToken cancellationToken)
		{
            var respones = await _httpClient.GetFromJsonAsync<List<ActorMoviesDto>>($"https://localhost:7211/api/Actor/get-actor-byflims?movieID={moviesId}");
            return respones;
		}

		public async Task<HttpResponseMessage> CreateGenre(CreateGenreRequest request)
		{
			var respones = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Genre/create-genre", request);
			return respones;
		}

		public async Task<HttpResponseMessage> CreateDirector(CreateDirectorRequest request)
		{
			var respones = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Director/CreateDirector", request);
			return respones;
		}

		public async Task<HttpResponseMessage> CreateLanguage(CreateLanguageRequest request)
		{
			var respones = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Language/create", request);
			return respones;
		}

		public async Task<HttpResponseMessage> CreateCountry(CountrysCreateRequest request)
		{
			var respones = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Country", request);
			return respones;
		}

		public async Task<HttpResponseMessage> CreateMovieType(CreateMovieTypeRequest request)
		{
			var respones = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/MovieType/CreateMovieType", request);
			return respones;
		}
	}
}