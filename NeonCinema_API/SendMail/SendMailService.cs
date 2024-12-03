namespace NeonCinema_API.SendMail
{
    public class SendMailService : ISendMailService
    {
        private readonly EmailSettings _emailSettings;

        public SendMailService(IConfiguration configuration)
        {
            _emailSettings = configuration.GetSection("EmailSettings").Get<EmailSettings>();
            if (_emailSettings == null)
            {
                throw new Exception("Cấu hình EmailSettings không được tìm thấy hoặc không đúng.");
            }
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            if (_emailSettings == null) throw new NullReferenceException("_emailSettings is null!");

            var emailMessage = new MimeKit.MimeMessage();
            emailMessage.From.Add(new MimeKit.MailboxAddress("Neon Cinemas", _emailSettings.Username));
            emailMessage.To.Add(new MimeKit.MailboxAddress("", toEmail));
            emailMessage.Subject = subject;
            emailMessage.Body = new MimeKit.TextPart("html") { Text = body };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync(_emailSettings.Host, _emailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(_emailSettings.Username, _emailSettings.Password);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}
