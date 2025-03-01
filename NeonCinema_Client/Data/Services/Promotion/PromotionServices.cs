﻿using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MudBlazor;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.DataTransferObject.Roles;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Client.Data.IServices.Promotion;
using NeonCinema_Domain.Database.Entities;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Text;

namespace NeonCinema_Client.Data.Services.Promotion
{
	public class PromotionServices : IPromotionServices
	{
		private readonly HttpClient _client;
		public PromotionServices(HttpClient client)
		{
			_client = client;
		}

		public async Task<bool> CreatePromotionAsync(PromotionCreateRequest input)
		{
			try
			{
				var result = await _client.PostAsJsonAsync("https://localhost:7211/api/Promotion/post", input);


				if (result.IsSuccessStatusCode)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public async Task<bool> CreatePromotionUserAsync(List<PromotionUserDTO> lstinput)
		{
			try
			{
				foreach (var item in lstinput)
				{
					try
					{
						var result = await _client.PostAsJsonAsync("https://localhost:7211/api/Promotion/create-promotion-user", item);
					}
					catch (Exception ex)
					{
						continue;
					}

				}
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<bool> DeletePromotionAsync(Guid id)
		{
			try
			{
				var result = await _client.DeleteAsync($"https://localhost:7211/api/Promotion/delete?id={id}");


				if (result.IsSuccessStatusCode)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<List<UserDTO>> GetAllUserAsync(string input)
		{
			var lst = new List<UserDTO>();
			var result = await _client.GetFromJsonAsync<List<UserDTO>>("https://localhost:7211/api/User/get-all");
			var lstrole = await _client.GetFromJsonAsync<List<RolesDTO>>("https://localhost:7211/api/Roles/get-all");

			if (result != null && lstrole != null)
			{
				RolesDTO role = lstrole.FirstOrDefault(x => x.RoleName == "Client");
				lst = result.Where(x => x.RoleID == role.ID && x.FullName.Trim().ToLower().Contains(input.Trim().ToLower())).ToList();
			}

			return lst;
		}

		public async Task<PromotionDTO> GetPromotionByIdAsync(Guid id)
		{
			var lst = await GetPromotionListAsync();

			var promotion = lst.Find(x => x.ID == id);

			if (promotion != null)
			{
				return promotion;
			}
			else
			{
				throw new Exception("Not Found");
			}
		}

		public async Task<List<PromotionDTO>> GetPromotionListAsync()
		{

			var result = await _client.GetFromJsonAsync<List<PromotionDTO>>("https://localhost:7211/api/Promotion/get-all");

			return result;
		}

		public Task<List<PromotionDTO>> SearchProByNameAsync(string input)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdatePromotionAsync(PromotionDTO input)
		{
			try
			{
				var result = await _client.PutAsJsonAsync("https://localhost:7211/api/Promotion/put", input);


				if (result.IsSuccessStatusCode)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		//Gửi mail
		public async Task SendMailWithTemplateAsync(List<MailPromotionRequest> lstMail)
		{
			try
			{
				var result = await _client.PostAsJsonAsync("https://localhost:7211/api/Promotion/send-mail", lstMail);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task<List<UserDTO>> GetPUbyProID(Guid id)
		{
			try
			{
				var result = await _client.GetFromJsonAsync<List<UserDTO>>($"https://localhost:7211/api/Promotion/get-user-by-promotionid?id={id}");

				return result;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
