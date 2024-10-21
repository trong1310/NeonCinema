using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Client.Data.IServices.Screenning;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class ScreeningService : IScreeningService
{
    private readonly HttpClient _httpClient;

    public ScreeningService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ScreeningDTO>> GetAllScreeningsAsync()
    {
        var response = await _httpClient.GetAsync("api/Screening/get-all-screenings");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<ScreeningDTO>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task<ScreeningDTO> GetScreeningByIdAsync(Guid id)
    {
        var response = await _httpClient.GetAsync($"api/Screening/get-screening-by-id/{id}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<ScreeningDTO>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task CreateScreeningAsync(ScreeningCreateRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Screening/create-screening", request);
        response.EnsureSuccessStatusCode();
    }

    public async Task UpdateScreeningAsync(ScreeningUpdateRequest request)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/Screening/update-screening/{request.ID}", request);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteScreeningAsync(Guid id)
    {
        var response = await _httpClient.DeleteAsync($"api/Screening/delete-screening/{id}");
        response.EnsureSuccessStatusCode();
    }
    public async Task<List<ShowTimeDTO>> GetAllShowTimesAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<ShowTimeDTO>>("api/ShowTime/get-all-showtime");
        return response;
    }

    public async Task<List<MovieDTO>> GetAllMoviesAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<MovieDTO>>("api/Movie/GetAll");
        return response;
    }

    public async Task<List<RoomDTO>> GetAllRoomsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<RoomDTO>>("api/Room/getall");
        return response;
    }

}
