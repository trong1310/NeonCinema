using AutoMapper;
using Com.CloudRail.SI.Interfaces;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace NeonCinema_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PromotionController : ControllerBase
	{
		private readonly IConfiguration _config;
		private readonly IEntityRepository<Promotion> _repos;
		private readonly IEntityRepository<PromotionUsers> _reposPU;
		private readonly IMapper _mapper;
		//private static Dictionary<string, DateTime> emailSendLog = new Dictionary<string, DateTime>();
		public PromotionController(IEntityRepository<Promotion> repos, IMapper mapper, IEntityRepository<PromotionUsers> reposPU, IConfiguration config)
		{
			_mapper = mapper;
			_repos = repos;
			_reposPU = reposPU;
			_config = config;
		}

		[HttpGet("get-all")]
		public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
		{
			try
			{
				var lst = await _repos.GetAll(cancellationToken);

				if (lst == null)
				{
					return BadRequest("Null");
				}

				return Ok(lst.Select(x => _mapper.Map<PromotionDTO>(x)).ToList());
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost("post")]
		public async Task<IActionResult> Post([FromBody] PromotionCreateRequest input, CancellationToken cancellationToken)
		{
			try
			{
				var result = await _repos.Create(_mapper.Map<Promotion>(input), cancellationToken);

				if (result.IsSuccessStatusCode)
				{
					return Ok(result.Content);
				}
				else
				{
					return BadRequest(result.Content);
				}

			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPut("put")]
		public async Task<IActionResult> Put([FromBody] PromotionDTO input, CancellationToken cancellationToken)
		{
			try
			{
				var result = await _repos.Update(_mapper.Map<Promotion>(input), cancellationToken);

				if (result.IsSuccessStatusCode)
				{
					return Ok(result.Content);
				}
				else
				{
					return BadRequest(result.Content);
				}

			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpDelete("delete")]
		public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
		{
			try
			{
				var entity = await _repos.GetById(id, cancellationToken);

				if (entity != null)
				{
					var result = await _repos.Delete(entity, cancellationToken);

					if (result.IsSuccessStatusCode)
					{
						return Ok(result.Content);
					}
					else
					{
						return BadRequest(result.Content);
					}
				}

				else
				{
					return BadRequest("Not Found");
				}
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost("create-promotion-user")]
		public async Task<IActionResult> CreatePU([FromBody] PromotionUserDTO input, CancellationToken cancellationToken)
		{
			try
			{
				var result = await _reposPU.Create(_mapper.Map<PromotionUsers>(input), cancellationToken);

				if (result.IsSuccessStatusCode)
				{
					return Ok(result.Content);
				}
				else
				{
					return BadRequest(result.Content);
				}

			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpGet("get-user-by-promotionid")]
		public async Task<IActionResult> GetUserByPid([FromQuery]Guid id, CancellationToken cancellationToken)
		{
			var lstPU = await _reposPU.GetAll(cancellationToken);
			List<PromotionUsers> lstPUbyId = lstPU.Where(x => x.PromotionID == id).ToList();

			List<UserDTO> lstUserDTO = new List<UserDTO>();

			foreach (var item in lstPUbyId)
			{
				UserDTO userDTO = new UserDTO
				{
					ID = item.UserID,
					FullName = item.User.FullName,
					PassWord = item.User.PassWord,
					PhoneNumber = item.User.PhoneNumber,
					Email = item.User.Email,
					Gender = item.User.Gender,
					Images = item.User.Images,
					DateOrBriht = item.User.DateOrBriht,
					Adderss = item.User.Adderss,
					Status = item.User.Status,
					RoleID = item.User.RoleID
				};

				lstUserDTO.Add(userDTO);
			}

			return Ok(lstUserDTO);
		}

		[HttpPost("send-mail")]
		public async Task<HttpResponseMessage> SendMail([FromBody]List<MailPromotionRequest> lstMail)
		{
			try
			{
				//var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.email);

				//if (user == null)
				//{
				//	return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
				//	{
				//		Content = new StringContent("Email không chính xác vui lòng thử lại")
				//	};
				//}
				//else
				//{
				//if (emailSendLog.ContainsKey(request.email))
				//{
				//	var timeSend = emailSendLog[request.email];
				//	if (DateTime.Now - timeSend < TimeSpan.FromMinutes(10))
				//	{
				//		return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
				//		{
				//			Content = new StringContent($"Vui lòng thử lại sau {DateTime.Now - timeSend} phút nữa")
				//		};
				//	}
				//}

				//emailSendLog[request.email] = DateTime.Now;

				// Khởi tạo mã ưu đãi (hoặc thông tin ưu đãi)

				var email = _config["EmailSetting:Username"]; //email from
				var appPass = _config["EmailSetting:Password"]; //app password

				foreach (var item in lstMail)
				{
					var emailMessage = new MimeMessage();
					string discounttext = "";
					if(item.DiscountPercentage != null)
					{
						discounttext = $"Giảm {item.DiscountPercentage}%";
					}
					else
					{
						discounttext = $"Giảm {item.DiscountAmount} VND";
					}

					emailMessage.From.Add(new MailboxAddress("Từ: ", email));
					emailMessage.To.Add(new MailboxAddress("Xin Chào: ", item.ToEmail));
					emailMessage.Subject = "Rạp chiếu phim NeonCinemas";

					var bodyEmail = new BodyBuilder
					{
						HtmlBody = @$"
                <h1>Chúc mừng bạn nhận được ưu đãi từ rạp chiếu phim NeonCinemas!</h1>
                <p>Xin chào {item.FullName},</p>
                <p>Chúng tôi vui mừng thông báo rằng bạn đã nhận được ưu đãi mới từ NeonCinemas!</p>
				<p>{item.NamePromotion}</p>
                <p>Ưu đãi giảm {discounttext} khi thanh toán hóa đơn đặt vé xem phim</p>
                <p>Thời hạn từ {item.StartDate.ToShortTimeString()} ngày {item.StartDate.ToShortDateString()} đến {item.EndDate.ToShortTimeString()} ngày {item.EndDate.ToShortDateString()}</p>
                <p>Hãy truy cập trang web của chúng tôi và nhập mã <strong>{item.Code}</strong> để nhận khuyến mãi đặc biệt này!</p>
                <p>Trân trọng,<br>Đội ngũ hỗ trợ khách hàng NeonCinemas</p>"
					};

					emailMessage.Body = bodyEmail.ToMessageBody();

					// Gửi email
					using (var client = new MailKit.Net.Smtp.SmtpClient())
					{
						client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
						client.Authenticate(email, appPass);
						client.Send(emailMessage);
						client.Disconnect(true);
					}
				}

				return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
				{
					Content = new StringContent("Thành Công! Email ưu đãi đã được gửi cho khách hàng.")
				};
				//}
			}
			catch (Exception ex)
			{
				return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
				{
					Content = new StringContent("Có lỗi xảy ra: " + ex.Message)
				};
			}
		}
	}
}
