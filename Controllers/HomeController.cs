using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DreamMessenger.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace DreamMessenger.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly AppUserManager _userManager; //класс для работы с пользователями

        //конструктор контроллера с передачей менеджеров и сервисов
        public HomeController(AppUserManager userManager)
        {
            _userManager = userManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index() //возврат главной страницы 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Groups() //возврат страницы с группами
        {
            return View();
        }

        [HttpGet]
        public IActionResult Status() //возврат страницы с статусами
        {
            return View();
        }

        [HttpGet]
        public IActionResult AudioCall() //возврат страницы с аудио-звонком
        {
            return View();
        }

        [HttpGet]
        public IActionResult Archived() //возврат страницы с архивными записями
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFriend(string Username, string Email) //метод добавления друзей (контактов)
        {
            //ищем пользователя (друга) по емейлу
            var friend = await _userManager.FindByEmailAsync(Email);

            //если нашли юзера
            if (friend != null)
            {
                //если его никнейм совпадает с введенным
                if (friend.UserName == Username)
                {
                    //получаем текущего юзера
                    var user = await _userManager.GetUserWithFriendsAsync(User);

                    //создаём объект друга с данными
                    Friends Friend = new()
                    {
                        FriendKey = friend.Id,
                        FriendUsername = friend.UserName,
                        FriendEmail = friend.Email,
                    };

                    //если друга нет в списке (не повторяется)
                    if (!user.Friends.Exists(x => x.FriendKey == friend.Id)) 
                    {
                        //добавляем друга с его Id и пр. данными
                        user.Friends.Add(Friend);
                        //обновляем пользователя
                        await _userManager.UpdateAsync(user);
                        //возвращаем текущую страницу
                        RedirectToAction("Index");
                    }
                    else //если пользователь уже в друзьях
                    {
                        ModelState.AddModelError("", $"User {Username} is already your friend");
                    }
                }
                else //если никнейм отличается - значит юзер не тот
                {
                    ModelState.AddModelError("", "Invalid Username for this user");
                }
            }
            else //если не нашли друга
            {
                ModelState.AddModelError("", "This user was not found");
            }

            //возвращаем главную страницу
            return View("Index");
        }
    }
}
