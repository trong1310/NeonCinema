using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Client.Data.IServices.MovieType;

namespace NeonCinema_Client.Data.Services.MovieType
{
    public class MovieTypeService : IMovieTypeService
    {
        private readonly HttpClient _httpClient;
        public MovieTypeService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task CreateMovieType(CreateMovieTypeRequest request)
        {
            await _httpClient.PostAsJsonAsync("api/MovieType/CreateMovieType", request);
        }

        public async Task<List<MovieTypeDTO>> GetAllMovieType()
        {
            return await _httpClient.GetFromJsonAsync<List<MovieTypeDTO>>("api/MovieType/Get-All");
        }

        public async Task<MovieTypeDTO> GetByIdMovieType(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<MovieTypeDTO>($"/api/MovieType/GetById/{id}");
        }

        public async Task UpdateMpvieTYpe(Guid id, UpdateMovieTypeRequest request)
        {
            await _httpClient.PutAsJsonAsync($"/api/MovieType/UpdateMovieTYpe/{id}", request);
        }
    }
}
