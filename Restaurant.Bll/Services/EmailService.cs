using Restaurant.Bll.Services.Interfaces;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            string senderEmail = "restaurantapi@outlook.com";
            string senderPassword = ":?FaQ5(iTK$4jhA";

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
