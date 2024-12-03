namespace NeonCinema_API.SendMail
{
    public interface ISendMailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
    }
}
