﻿using Blazorise;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.Screenning;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
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

    public async Task UpdateScreeningAsync(Guid id)
    {
        using (var context = new NeonCinemasContext())
        {
            var scr = await context.Screening.FindAsync(id);

            if(scr != null && scr.Status == ScreeningStatus.InActive)
            {
                scr.Status = ScreeningStatus.Cancelled;

                context.Screening.Update(scr);
                await context.SaveChangesAsync();
            }
        }
    }

    public async Task<bool> DeleteScreeningAsync(Guid id)
    {
        try
        {
			var response = await _httpClient.PutAsJsonAsync($"https://localhost:7211/api/Screening/delete?id={id}", (object)null);

			if (response.IsSuccessStatusCode)
			{
				return true;
			}
			else
			{
				throw new Exception($"StatusCode: {response.StatusCode}, Reason: {response.ReasonPhrase}");
			}
		}
        catch (Exception ex) 
        {
            throw new Exception($"Error {ex.Message} : {ex.StackTrace}");
        }
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
	public async Task<List<ShowTimeDTO>> GetShowTimebyRoomAndDate(Guid? roomId, DateTime? showDate)
	{
		try
		{
			if (roomId == null || showDate == null)
			{
				throw new ArgumentException("Room ID and Show Date must not be null.");
			}

			// Lấy danh sách lịch chiếu từ API
			var result = await _httpClient.GetFromJsonAsync<List<ScreeningSupportValidate>>(
				$"https://localhost:7211/api/Screening/get-scr-by-room-and-showdate?roomId={roomId}&showDate={showDate}");

			if (result == null || !result.Any())
			{
				return new List<ShowTimeDTO>(); // Không có dữ liệu
			}

			// Lấy danh sách ID của showtime
			var lstIdShowtime = result.Select(x => x.ShowTimeID).ToList();

			// Lấy tất cả các showtime
			var lstShowTime = await GetAllShowTimesAsync() ?? new List<ShowTimeDTO>();

			// Lọc danh sách showtime
			return lstShowTime.Where(x => lstIdShowtime.Contains(x.ID)).ToList();
		}
		catch (Exception ex)
		{
			throw new Exception($"Error in GetShowTimebyRoomAndDate: {ex.Message}", ex);
		}
	}

	public Task<bool> ValidateShowTimeInRoom(Guid roomId)
	{
		throw new NotImplementedException();
	}
}
