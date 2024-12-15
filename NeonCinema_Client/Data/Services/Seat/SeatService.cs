using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.Seat;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Implement.Seats;
using System.Text.Json;



//using System.Text.Json;
using System.Threading;

namespace NeonCinema_Client.Data.Services.Seat
{
    public class SeatService : ISeatService
    {
        private readonly NeonCinemasContext _context;
        private readonly HttpClient _httpClient;
        public SeatService(HttpClient httpclient, NeonCinemasContext context)
        {
            _httpClient = httpclient;
            _context = context;
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

        public async Task<List<RoomDTO>> GetAllRooms()
        {
            var response = await _httpClient.GetFromJsonAsync<List<RoomDTO>>("api/Room/all");
            return response ?? new List<RoomDTO>();
        }

        public async Task<PaginationResponse<SeatDTO>> GetAllSeat(ViewSeatRequest request)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<PaginationResponse<SeatDTO>>(
                    $"https://localhost:7211/api/Seat/GetAll?PageNumber={request.PageNumber}&PageSize={request.PageSize}");
                return response ?? new PaginationResponse<SeatDTO>();
            }
            catch (HttpRequestException e)
            {
                throw new Exception("Error fetching seats: " + e.Message, e);
            }
        }

        public async Task<List<SeatDTO>> GetAllSeats(CancellationToken cancellationToken)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<SeatDTO>>("https://localhost:7211/api/Seat/GetAll");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching all seats: " + ex.Message);
            }
        }

        public async Task<List<SeatTypeDTO>> GetAllSeatType()
        {
            return await _httpClient.GetFromJsonAsync<List<SeatTypeDTO>>("api/SeatType/Get-all");
        }

        public async Task<SeatDTO> GetSeatById(Guid id)
        {
            var respones = await _httpClient.GetFromJsonAsync<SeatDTO>($"https://localhost:7211/api/Seat/GetById?id={id}");
            return respones;
        } 

       

        public async Task<HttpResponseMessage> UpdateSeate(Guid id, UpdateSeatDTO request)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"https://localhost:7211/api/Seat/Update?id={id}", request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("co loi xay ra : " + ex.Message);
            }
        }

        public async Task UpdateSeatsAsync(List<Guid> selectedSeatIds, Guid newSeatTypeId)
        {
            var seatType = await _context.SeatTypes.FindAsync(newSeatTypeId);
            if (seatType == null)
            {
                throw new ArgumentException("Seat type not found.", nameof(newSeatTypeId));
            }
            var seatsToUpdate = await _context.Seat
            .Where(s => selectedSeatIds.Contains(s.ID)).ToListAsync();
            foreach (var seat in seatsToUpdate)
            {
                seat.SeatTypeID = newSeatTypeId;
            }
            _context.Seat.UpdateRange(seatsToUpdate);
            await _context.SaveChangesAsync();
        }
    }
}
