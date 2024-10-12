using Bogus.Hollywood.Models;
using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.IMoviesServices;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_Client.Services.MoivesService
{
    public class MoviesServices : IMovieservices
    {

        private readonly HttpClient _httpClient;

        public MoviesServices()
        {
            _httpClient = new HttpClient();
        }
        public async Task<HttpResponseMessage> CreateMovie(CreateMovieRequest request)
        {
            
            try
            {
                var result = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Movie/Create", request);
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

    }

}