using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Client.Data.IServices.Language;

public class LanguageService : ILanguageService
{
    private readonly HttpClient _httpClient;

    public LanguageService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<LanguageDTO>> GetAllLanguages()
    {
        return await _httpClient.GetFromJsonAsync<List<LanguageDTO>>("api/Language/get-all");
    }

    public async Task<LanguageDTO> GetLanguageById(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<LanguageDTO>($"api/Language/get-by-id/{id}");
    }

    public async Task CreateLanguage(CreateLanguageRequest request)
    {
        await _httpClient.PostAsJsonAsync("api/Language/create", request);
    }

    public async Task UpdateLanguage(Guid id, UpdateLanguageRequest request)
    {
        await _httpClient.PutAsJsonAsync($"api/Language/update/{id}", request);
    }

    public async Task DeleteLanguage(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Language/delete/{id}");
    }
}
