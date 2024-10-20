using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.SeatType;

namespace NeonCinema_Client.Data.Services.SeatType
{
    public class SeatTypeService : ISeatTypeService
    {
        private readonly HttpClient _httpClient;
        public SeatTypeService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task CreateSeatType(CreateSeatTypeDTO request)
        {
            await _httpClient.PostAsJsonAsync("api/SeatType/Create-SeatType", request);
        }

        public async Task<List<SeatTypeDTO>> GetAllSeatType()
        {
            return await _httpClient.GetFromJsonAsync<List<SeatTypeDTO>>("api/SeatType/Get-all");
        }

        public async Task<SeatTypeDTO> GetByIdSeatType(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<SeatTypeDTO>($"api/SeatType/Get-by-id/{id}");
        }

        public async Task UpdateSeatType(Guid id, UpdateSeatTypeDTO request)
        {
            await _httpClient.PutAsJsonAsync($"api/SeatType/Update-SeatType/{id}", request);
        }
        public async Task<PaginationResponse<SeatTypeDTO>> GetAllSeatType(PaginationRequest request)
        {
            var response = await _httpClient.GetFromJsonAsync<PaginationResponse<SeatTypeDTO>>($"api/SeatType/Get-all?pageNumber={request.PageNumber}&pageSize={request.PageSize}");
            return response;
        }

    }
}
