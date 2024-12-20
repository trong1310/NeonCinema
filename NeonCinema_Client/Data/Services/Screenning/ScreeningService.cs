using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.Screenning;
using NeonCinema_Domain.Enum;
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
        try
        {
			var response = await _httpClient.GetFromJsonAsync<PaginationResponse<ScreeningDTO>>("https://localhost:7211/api/Screening/get-all-screenings");
			return response.Data.ToList();
		}
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        
    }

    public async Task<ScreeningDTO> GetScreeningByIdAsync(Guid id)
    {
        var response = await _httpClient.GetAsync($"api/Screening/get-screening-by-id/{id}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<ScreeningDTO>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task<bool> CreateScreeningAsync(ScreeningCreateRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Screening/create-screening", request);
        if(response.IsSuccessStatusCode)
        {
            return true;
        }
        else return false;
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
        var response = await _httpClient.GetFromJsonAsync<List<ShowTimeDTO>>("https://localhost:7211/api/ShowTime/get-all-showtime");
        return response;
    }

    public async Task<PaginationResponse<MovieDTO>> GetAllMoviesAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<PaginationResponse<MovieDTO>>("https://localhost:7211/api/Movie/GetAll");
        return response;
    }

    public async Task<List<RoomDTO>> GetAllRoomsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<RoomDTO>>("https://localhost:7211/api/Room/all");
        return response;
    }

	public async Task<bool> CreateSSS(SeatShowTimeStatusDTO input)
	{
        var response = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Screening/create-sss", input);

        if(response.IsSuccessStatusCode)
        {
            return true;
        }
        else return false;
	}

    //validate nè
	public async Task<List<ShowTimeDTO>> GetShowTimebyRoomAndDate(Guid roomId, DateTime showDate)
	{
        try
        {
            //lấy danh sách lịch chiếu đã lọc
            var result = await _httpClient.GetFromJsonAsync<List<ScreeningSupportValidate>>(
        $"https://localhost:7211/api/Screening/get-scr-by-room-and-showdate?roomId={roomId}&showDate={showDate}");

            List<ScreeningSupportValidate> lstScr = result ?? new List<ScreeningSupportValidate>();

            //lấy danh sách id showtime từ danh sách lịch chiếu trên
            var lstIdShowtime = new List<Guid>();


            foreach (var item in lstScr)
            {
                lstIdShowtime.Add(item.ShowTimeID);
            }

            var lstShowTime = await GetAllShowTimesAsync();



            //lọc danh sách showtime theo danh sách ID và trả về
            return lstShowTime.Where(x => lstIdShowtime.Contains(x.ID)).ToList(); // cần sửa đoạn này
        }
        catch (Exception ex) { throw new Exception(ex.Message); }
		
 	}

	public Task<bool> ValidateShowTimeInRoom(Guid roomId)
	{
		throw new NotImplementedException();
	}
}
