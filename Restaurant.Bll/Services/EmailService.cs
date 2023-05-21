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
            string senderEmail = "daniuxa88@gmail.com";
            string senderPassword = "lwnyfyrajcgghxry";
            string recipientEmail = toEmail;

            MailMessage message = new MailMessage(senderEmail, recipientEmail);
            message.Subject = subject;
            message.Body = body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true; // Enable SSL/TLS encryption
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.UseDefaultCredentials = true;
            try
            {
                await smtpClient.SendMailAsync(message);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email. Error message: " + ex.Message);
            }
        }
    }
}
