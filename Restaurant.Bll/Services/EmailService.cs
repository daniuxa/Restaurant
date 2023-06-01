using Microsoft.Extensions.Configuration;
using Restaurant.Bll.Services.Interfaces;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            this._configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var senderEmail = _configuration.GetSection("LoginIntoMailAccount").GetSection("Email").Value;
            var senderPassword = _configuration.GetSection("LoginIntoMailAccount").GetSection("Password").Value;

            var client = new SmtpClient("smtp.office365.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail, senderPassword)
            };

            await client.SendMailAsync(
                new MailMessage(from: senderEmail,
                                to: toEmail,
                                subject,
                                body
                                ));
        }
    }
}
