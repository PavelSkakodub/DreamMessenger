
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
        //метод настройки сообщения и отправки
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new("alex.rabota.2000@mail.ru", "Dream Messenger");
            // кому отправляем
            MailAddress to = new(email);
            // создаем объект сообщения
            MailMessage m = new(from, to)
            {
                Subject = subject, //тема письма
                Body = message, //текст письма
                IsBodyHtml = true//письмо представляет код html
            };
            await SendMessage("alex.rabota.2000@mail.ru", "0gqCHhWwM1Gn9J3iZ5p9", m); //отправляем сообщение
        }

        //метод аутенфикации и отправки сообщения
        public async Task SendMessage(string email, string password, MailMessage m)
        {
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new("smtp.mail.ru", 587);
            // логин и пароль
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(email, password);
            //отправка сообщения
            await smtp.SendMailAsync(m);
        }
    }
}
