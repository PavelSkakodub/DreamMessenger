using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DreamMessenger.Models;
using System.Threading.Tasks;
using DreamMessenger.Models.AccountModels;
using Microsoft.AspNetCore.Authorization;
using DreamMessenger.Services;
using System;
using DreamMessenger.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace DreamMessenger.Controllers
{
    //[AllowAnonymous] - доступ к методу для любого пользователя
    [Authorize] //доступ к контроллеру только для авторизованного пользователя
    public class AccountController : Controller
    {
        private readonly AppUserManager _userManager; //класс для работы с пользователями
        private readonly SignInManager<UserIdentity> _signInManager; //класс с функциями аутентификации по паролю,вход и выход юзера (через куки)
        private readonly IViewRenderService _viewRenderService; //сервис конверта html
        private readonly IEmailService _emailService; //сервис отправки сообщений на почту

        //конструктор контроллера с передачей менеджеров и сервисов
        public AccountController(AppUserManager userManager, SignInManager<UserIdentity> signInManager, IViewRenderService viewRenderService, IEmailService emailService)
        {
            _userManager = userManager; //инициализируем менеджера для работы с юзером
            _signInManager = signInManager; //инициализируем менеджер аутенфик-ий юзера
            _viewRenderService = viewRenderService; //инициализируем сервис конверта html
            _emailService = emailService; //инициализируем сервис email отправки
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignUp() //возрат страницы регистрации
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login() //возврат страницы входа
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword() //возврат страницы сброса пароля
        {
            return View();
        }

        [HttpGet]
        public IActionResult Settings() //возврат страницы настроек профиля
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code, string email) //возврат формы сброса пароля
        {
            //создаём модель сброса пароля с передачей получ.токена и Id с емейлом
            ResetPassword reset = new()
            {
                Code = code,
                Email = email
            };

            //возврат страницы с формой сброса пароля
            return View("ResetPassword", reset); 
        }

        [HttpGet]
        public async Task<IActionResult> Logout() //выход из аккаунта 
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            //редиректим на страницу авторизации
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public async Task<IActionResult> Delete() //удаление аккаунта (блокировка навсегда)
        {
            //получаем текущего пользователя
            UserIdentity user = await _userManager.GetUserAsync(User);
            
            //если пользователь есть (авторизован)
            if (user != null)
            {
                //блокируем пользователя на 200 лет и ставим св-во БлокировкаНавсегда true
                user.IsBlockedForever = true;
                user.LockoutEnd = System.DateTimeOffset.Now.AddYears(200);

                //обновляем юзера
                await _userManager.UpdateAsync(user);
                //выходим принудительно (т.к куки остались)
                await _signInManager.SignOutAsync();

                //редиректим на логин
                return RedirectToAction("Login"); 
            }

            //если юзера нет кидаем на регистрацию
            return RedirectToAction("SignUp"); 
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code) //подтверждение емейла по токену из почты юзера
        {
            //если пришли Id юзера и его токен
            if (userId != null && code != null)
            {
                //получаем юзера по переданному Id
                var user = await _userManager.FindByIdAsync(userId);

                //если нашли юзера по его Id
                if (user != null) 
                {
                    //делаем подтверждение емейла
                    var result = await _userManager.ConfirmEmailAsync(user, code);

                    //если подтверждение успешно редиректим на страницу входа
                    if (result.Succeeded) 
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }            
            }

            //если подтверждение не удалось возврат страницы с ошибкой
            return Content("Error");
        }




        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp(RegisterModel model) //регистрация пользователей
        {
            if (ModelState.IsValid) //если валидация модели успешна
            {
                //создаём пользователя с его данными 
                UserIdentity userIdentity = new() { FirstName = model.FirstName, LastName = model.LastName, Email = model.Email, UserName = model.Email, RegistrationDate = DateTime.Now, BaseUser = new BaseUser() { LastUpdate = System.DateTime.Now }, Friends = new() };
                //добавляем пользователя
                var result = await _userManager.CreateAsync(userIdentity, model.Password);
                
                //если успешно добавили
                if (result.Succeeded)
                {
                    //генерируем уник.токен подтверждения
                    var code = _userManager.GenerateEmailConfirmationTokenAsync(userIdentity);
                    //создаём url с передачей в него Id и токена подтверждения юзера - редирект на метод ConfirmEmail c арг .Id и token
                    var callbackUrl = Url.Action("ConfirmEmail","Account",new { userId = userIdentity.Id, code = code.Result }, protocol: HttpContext.Request.Scheme);

                    //создаём объект модели подтверждения почты
                    EmailConfirm confirmModel = new()
                    {
                        FirstName = userIdentity.FirstName,
                        LastName = userIdentity.LastName,
                        CallbackUrl = callbackUrl,
                        Date = System.DateTime.Now,
                        Email = userIdentity.Email                        
                    };

                    //конвертируем переданное представление с моделью в html-страницу для отправки на почту
                    var htmlEmail = await _viewRenderService.RenderToStringAsync("EmailConfirm", confirmModel);                  
                    //отправляем сообщение на емейл юзера с передачей страницы (сообщения)
                    await _emailService.SendEmailAsync(model.Email, "Account confirmation", htmlEmail);

                    //возвращаем сообщение о завершениии регистрации
                    return Content("Confirm your email to complete registration.");
                }
                else
                {
                    //перебор и добавление ошибок в состояние модели
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            //если не удалось - возвращаем страницу
            return View(model); 
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model) //авторизация пользователя
        {
            //получаем юзера по емейл
            var user = await _userManager.FindByEmailAsync(model.Email);

            //если пользователя не существует или удалён
            if (user == null || user.IsBlockedForever) 
            {
                ModelState.AddModelError(string.Empty, "User is not found");
                return View();
            }

            //если емейл не подтверждён
            if (!user.EmailConfirmed) 
            {
                ModelState.AddModelError(nameof(model.Email), "Confirm your email first");
                return View();
            }

            //если пользователь заблокирован при входе (время блокировки не прошло)
            if (user.LockoutEnd > DateTimeOffset.Now) 
            {
                ModelState.AddModelError(string.Empty, "Too many login attempts. Repeat after 30 minutes");
                return View();
            }

            //авторизуемся, создавая файл cookie и возвращаем Task авторизации
            //isPersistent - флаг, указывающий, должен ли файл cookie для входа сохраняться после закрытия браузера
            //lockoutOnFailure - флаг, указывающий, следует ли блок. пользователя на время в случае неуд-ых попыток входа
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, isPersistent: model.RememberMe, lockoutOnFailure: true);

            //если задача не сработала
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Invalid login or password");
                return View();
            }

            //обнуляем неудачные попытки входа
            user.AccessFailedCount = 0;

            //если успешно вошли редиректим
            return RedirectToAction("Index", "Home"); 
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(string Email) //сброс пароля
        {
            if (ModelState.IsValid) //если модель валидна
            {
                //получаем юзера из БД по емейлу
                var user = await _userManager.FindByEmailAsync(Email);
   
                //если юзера нету или его емейл не подтверждён или заблокирован навсегда
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)) || user.IsBlockedForever)
                {
                    //добавляем ошибку и возвращаем страницу
                    ModelState.AddModelError(string.Empty, "User is not found");
                    return View();
                }

                //генерируем токен сброса пароля
                var codePas = await _userManager.GeneratePasswordResetTokenAsync(user);
                //создаём url с передачей в него Id и токена подтверждения юзера - редирект на метод ResetPassword c арг .Id, token и емейл
                var callbackUrl = Url.Action("ResetPassword", "Account", new { code = codePas , email = Email}, protocol: HttpContext.Request.Scheme);

                //создаём модель для сообщения о сбросе пароля
                ResetPasswordViewModel model = new()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    CallbackUrl = callbackUrl,
                    Date = System.DateTime.Now.ToString("D")
                };

                //конвертируем переданное представление с моделью в html-страницу для отправки на почту
                var htmlEmail = await _viewRenderService.RenderToStringAsync("EmailResetPassword", model);
                //отправлем сообщение на почту юзера
                await _emailService.SendEmailAsync(Email, "Reset Password", htmlEmail);

                //возврат сообщения об отправке
                return Content("Email message is send."); //уведомление об успешной отправке
            }

            return View(); //возврат этой же страницы
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPassword model) //сброс пароля по токену из почты юзера
        {
            //если модель не валидна
            if (ModelState.IsValid)
            {
                //получаем юзера по емейлу
                var user = await _userManager.FindByEmailAsync(model.Email);
                //сбрасываем пароль на указанный
                var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);

                //если успешно изменили пароль - возврат на вход
                if (result.Succeeded)
                {
                    return View("Login");
                }

                //иначе добавляем ошибки
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            //возврат страницы с ошибками
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Settings(SettingsModel model) //заполнение настроек пользователя
        {
            //если модель валидина
            if (ModelState.IsValid)
            {
                //получаем пользователя со всеми его данными
                var user = await _userManager.GetUserIdentityAsync(User);

                //устанавливаем новые значения
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PhoneNumber = model.PhoneNumber;
                user.UserName = model.NickName;
                //устанавливаем новые значения связанных данных
                user.BaseUser.Location = model.Location;
                user.BaseUser.Bio = model.Bio;
                user.BaseUser.LastUpdate = DateTime.Now;
                user.BaseUser.ProfilePhoto = model.ProfilePhoto;
                user.BaseUser.Facebook = model.FacebookLink;
                user.BaseUser.Twitter = model.TwitterLink;
                user.BaseUser.Linkedin = model.LinkedinLink;
                user.BaseUser.Instagram = model.InstagramLink;
                user.BaseUser.Youtube = model.YoutubeLink;

                //сохранение новых данных юзера
                await _userManager.UpdateAsync(user);

                //редиректим на эту же страницу(чтобы отобраз.новые данные)
                return RedirectToAction("Settings");
            }

            //иначе возвращаем страницу с ошибками
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> EditPassword(EditPassword model) //изменение пароля в настройках
        {
            //если модель валидна
            if (ModelState.IsValid) 
            {
                //получаем текущего пользователя
                var user = await _userManager.GetUserAsync(User);

                //изменяем пароль юзера на новый
                var editResult = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

                //если успешно - редиректим на эту же страницу
                if (editResult.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
                //иначе добавляем ошибки в статус модели и редиректим на
                else
                {
                    foreach (var er in editResult.Errors)
                    {
                        ModelState.AddModelError("", er.Description);
                    }
                }
            }

            //редиректим на страницу настроек
            return RedirectToAction("Settings");

        }
    }
}
