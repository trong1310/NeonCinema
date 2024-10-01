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

		public  async Task<List<MovieDTO>> GetAllMovies( )
        {
            var obj = await _httpClient.GetFromJsonAsync<List<MovieDTO>>("https://localhost:7211/api/Movie/GetAll");
            return obj;
        }

    }
}
