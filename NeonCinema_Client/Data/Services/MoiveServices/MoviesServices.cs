using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.IMoviesServices;

namespace NeonCinema_Client.Services.MoivesService
{
    public class MoviesServices : IMovieservices
    {
        private  readonly HttpClient _httpClient;
        public MoviesServices()
        {
            _httpClient = new HttpClient();
        }

		public async Task<List<MovieDTO>> FilMovie(List<MovieDTO> lst, Func<MovieDTO, bool> dk1 = null, Func<MovieDTO, bool> dk2 = null, Func<MovieDTO, bool> dk3 = null, Func<MovieDTO, bool> dk4 = null)
		{
			var query = lst.AsQueryable();

			if (dk1 != null)
			{
				query = query.Where(dk1).AsQueryable();
			}

			if (dk2 != null)
			{
				query = query.Where(dk2).AsQueryable();
			}

			if (dk3 != null)
			{
				query = query.Where(dk3).AsQueryable();
			}

			if (dk4 != null)
			{
				query = query.Where(dk4).AsQueryable();
			}

			return query.ToList();
		}

		public async Task<bool> CreateMovie(CreateMovieRequest input)
		{
			//chua validate
			var result = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Movie/Create", input);

			if(result.IsSuccessStatusCode)
			{
				return true;
			}
			return false;
		}

		public async Task<List<GenreDTO>> GetAllGenre()
		{
			var lst = await _httpClient.GetFromJsonAsync<List<GenreDTO>>("https://localhost:7211/api/Genre/get-all-genre");
			return lst;
		}

		public async Task<List<CountryDTO>> GetAllCountry()
		{
			var lst = await _httpClient.GetFromJsonAsync<List<CountryDTO>>("https://localhost:7211/api/Country/get-all");
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

		public async Task<List<MovieDTO>> GetAllMovies( )
        {
            var obj = await _httpClient.GetFromJsonAsync<List<MovieDTO>>("https://localhost:7211/api/Movie/GetAll");
            return obj;
        }
	}
}
