using System.Net.Mail;
using System.Net;
using MimeKit;

namespace practic
{
    public class Service
    {
        private readonly ILogger<Service> logger;
        public Service(ILogger<Service> logger)
        {
            this.logger = logger;
        }
        public void SendEmail(string name, string longDesc, string email)
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(name, email));
                message.To.Add(new MailboxAddress("", "shura.khatironov.04@mail.ru"));
                message.Subject = longDesc;
                message.Body = new BodyBuilder() { HtmlBody = "<div style=\"color: red;\">Сообщение от system</div>" }.ToMessageBody();

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.yandex.ru", 465, false);
                    client.Authenticate("alexander4ar@yandex.ru", "Sasha290104");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }
        }
    }
}
