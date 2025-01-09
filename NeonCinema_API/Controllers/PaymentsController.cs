using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/payments")]
public class PaymentsController : ControllerBase
{
	private readonly PayOSService _payosService;

	public PaymentsController(PayOSService payosService)
	{
		_payosService = payosService;
	}

	[HttpPost("create")]
	public async Task<IActionResult> CreatePayment([FromBody] PaymentRequest request)
	{
		var paymentUrl = await _payosService.CreatePaymentAsync(request.Amount, request.Description);
		return Ok(new { PaymentUrl = paymentUrl });
	}

	[HttpPost("webhook")]
	public IActionResult HandleWebhook([FromBody] WebhookRequest request)
	{
		string checksumData = $"{request.ClientId}|{request.ApiKey}|{request.Status}|{_payosService._settings.ChecksumKey}";
		string calculatedChecksum = _payosService.GenerateChecksum(checksumData);

		if (request.Checksum != calculatedChecksum)
		{
			return BadRequest("Invalid checksum.");
		}
		if (request.Status == "success")
		{
		}
		else if (request.Status == "canceled")
		{
		}

		return Ok();
	}
}

public class PaymentRequest
{
	public decimal Amount { get; set; }
	public string Description { get; set; }
}

public class WebhookRequest
{
	public string ClientId { get; set; }
	public string ApiKey { get; set; }
	public string Status { get; set; }
	public string Checksum { get; set; }
}
