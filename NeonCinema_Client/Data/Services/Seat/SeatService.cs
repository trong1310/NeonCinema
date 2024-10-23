using Microsoft.AspNetCore.Http.HttpResults;
using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.Seat;
using NeonCinema_Infrastructure.Implement.Seats;
using System.Text.Json;
using System.Threading;

namespace NeonCinema_Client.Data.Services.Seat
{
    public class SeatService : ISeatService
    {
        
        private readonly HttpClient _httpClient;
        public SeatService(HttpClient httpclient)
        {
            _httpClient = httpclient;
            
        }

        public async Task<HttpResponseMessage> CreateSeat(CreateSeatDTO request)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Seat/Create", request);
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

        public async Task<PaginationResponse<SeatDTO>> GetAllSeat(ViewSeatRequest request)
        {
            try
            {
                var results = await _httpClient.GetFromJsonAsync<PaginationResponse<SeatDTO>>($"https://localhost:7211/api/Seat/GetAll?PageNumber={request.PageNumber}&PageSize={request.PageSize}");
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception("co loi xay ra : " + ex.Message);
            }
        }

        public async Task<List<SeatTypeDTO>> GetAllSeatType()
        {
            
                
            var lst = await _httpClient.GetFromJsonAsync<List<SeatTypeDTO>>("https://localhost:7211/api/SeatType/Get-all");
            return lst;

        }

        public async Task<SeatDTO> GetSeatById(Guid id)
        {
            var respones = await _httpClient.GetFromJsonAsync<SeatDTO>($"https://localhost:7211/api/Seat/GetById?id={id}");
            return respones;
        }

        public async Task<HttpResponseMessage> UpdateSeate(UpdateSeatDTO request)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"https://localhost:7211/api/Seat/Update/{request.ID}", request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("co loi xay ra : " + ex.Message);
            }
        }

        
    }
}
