﻿using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.FlimsUser;
using NeonCinema_Client.DataTransferObject.MovieData;
using System.Net.Http;

namespace NeonCinema_Client.Data.Services.FilmUsers
{
	public class FlimUsers : IFlimUsers
    {
        HttpClient _httpClient;
        public FlimUsers()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<MovieData>> GetMovieComing()
        {
            var getflims = await _httpClient.GetFromJsonAsync<List<MovieData>>("https://localhost:7211/api/UserFlims/Get-coming");
            return getflims;
        }
        public async Task<PaginationResponse<MovieDTO>> GetMovieShowing(ViewMovieRequest request)
        {
            var getflims = await _httpClient.GetFromJsonAsync<PaginationResponse<MovieDTO>>($"https://localhost:7211/api/UserFlims/Get-showing?PageNumber={request.PageNumber}&PageSize={request.PageSize}");
            return getflims;
        }

		public async Task<List<MovieData>> GetStopShowing()
		{
			var getflims = await _httpClient.GetFromJsonAsync<List<MovieData>>("https://localhost:7211/api/UserFlims/GetStopShowing");
			return getflims;
		}
	}
}
