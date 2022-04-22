using DreamMessenger.Models;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DreamMessenger.Hubs
{
    public class ChatHub:Hub
    {
        private readonly AppUserManager _userManager; //класс для работы с пользователями

        public ChatHub(AppUserManager userManager) //переедаём в конструктор менеджер юзеров
        {
            _userManager = userManager;
        }

        //метод приёма сообщения и его обработки/отправки
        public async Task SendMessage(string UserId, string userName, string message)
        {
            //отправка сообщения на JS-клиент с передачей имени и сообщения
            await Clients.All.SendAsync("ReceiveMessage", userName, message);
            //
            var us = await _userManager.FindByIdAsync(UserId);
            Debug.WriteLine(us.FirstName + us.LastName);
        }
    }
}
