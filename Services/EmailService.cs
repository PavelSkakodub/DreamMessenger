using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DreamMessenger.Services
{
    //интерфейс Email сервиса 
    public interface IEmailService
    {
        //метод отправки сообщения
         Task SendEmailAsync(string email, string subject, string message);
    }

    //сервис отправки сообщений на почту юзерам
    public class EmailService:IEmailService
    {
        //настройки из конфигураций
        public IConfiguration Configuration { get; }

        public EmailService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //метод настройки сообщения и отправки
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new("alex.rabota.2000@mail.ru", Configuration["EmailSender:name"]);
            // кому отправляем
            MailAddress to = new(email);
            // создаем объект сообщения
            MailMessage m = new(from, to)
            {
                Subject = subject, //тема письма
                Body = message, //текст письма
                IsBodyHtml = true//письмо представляет код html
            };
            //отправляем сообщение с логами от почты из user secrets
            await SendMessage(Configuration["login"],Configuration["password"], m); 
        }

        //метод аутенфикации и отправки сообщения
        public async Task SendMessage(string email, string password, MailMessage m)
        {
            // адрес smtp-сервера(хост) и порт, с которого будем отправлять письмо
            SmtpClient smtp = new(Configuration["EmailSender:host"], int.Parse(Configuration["EmailSender:port"]));
            // логин и пароль
            smtp.EnableSsl = bool.Parse(Configuration["EmailSender:ssl"]);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(email, password);
            //отправка сообщения
            await smtp.SendMailAsync(m);
        }
    }
}
