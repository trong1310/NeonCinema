using NeonCinema_Application.DataTransferObject.Genre;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using NeonCinema_Client.Data.IServices.Genre;
using NeonCinema_Domain.Database.Entities;
using static Bogus.DataSets.Name;

namespace NeonCinema_Client.Data.Services.Genre
{
    public class GenreService : IGenreService
    {
        private readonly HttpClient _httpClient;

        public GenreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Lấy danh sách thể loại
        public async Task<List<GenreDTO>> GetAllGenres(CancellationToken cancellationToken)
        {
            return await _httpClient.GetFromJsonAsync<List<GenreDTO>>("api/Genre/get-all-genre", cancellationToken);
        }

        // Lấy thể loại theo ID
        public async Task<GenreDTO> GetGenreById(Guid id, CancellationToken cancellationToken)
        {
            return await _httpClient.GetFromJsonAsync<GenreDTO>($"api/Genre/get-by-id-genre?id={id}", cancellationToken);
        }

       

        public async Task CreateGenre(CreateGenreRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Genre/create-genre", request, cancellationToken);
            response.EnsureSuccessStatusCode();
            
        }

        public async Task UpdateGenre(Guid id, UpdateGenreRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Genre/update-genre?id={id}", request, cancellationToken);
            response.EnsureSuccessStatusCode();
        }

       async Task IGenreService.DeleteGenre(Guid id, CancellationToken cancellationToken)
        {
            var response = await _httpClient.DeleteAsync($"api/Genre/delete-genre?id={id}", cancellationToken);
            response.EnsureSuccessStatusCode();
        }

    }
}
