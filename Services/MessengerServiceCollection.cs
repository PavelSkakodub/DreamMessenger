using DreamMessenger.Data;
using DreamMessenger.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace DreamMessenger.Services
{
    //внедрение сервисов через отдельный класс
    public static class MessengerServiceCollection
    {
        //метод подключения сервисов
        public static IServiceCollection AddMessengerServices(this IServiceCollection services)
        {
            AddMyServices(services);
            AddIdentityServices(services);
            return services;
        }

        //подключение сервисов работы приложения
        private static void AddMyServices(IServiceCollection services)
        {
            //подключаем контекст БД внутри которого строка подключения и пр. данные
            services.AddDbContext<AppIdentityDbContext>();
            //подключаем наш реализованный менеджер пользователей
            services.AddTransient<AppUserManager>();
            //сервисы создаются при новом запросе
            services.AddScoped<IViewRenderService, ViewRenderService>(); //сервис конверта в html страницу
            services.AddScoped<IEmailService, EmailService>(); //сервис емейл отправки сообщений
            //добавляем сервис SignalR с вкл. подробных ошибок
            services.AddSignalR(x => x.EnableDetailedErrors = true);
            //добавляем использование MVC-архитектуры
            services.AddControllersWithViews();
        }

        //подключение сервисов Identity
        private static void AddIdentityServices(IServiceCollection services)
        {
            //добавление и настройка системы идентификации под наш класс UserIdentity и роль
            services.AddIdentity<UserIdentity, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true; // уникальный email
                opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // допустимые символы (любое имя юзера)
                opts.SignIn.RequireConfirmedEmail = true; //обязат.подтвержденный емейл
                opts.SignIn.RequireConfirmedEmail = true; //должен быть подтверждеён емейл
            }).AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders(); //функциональность генерации токенов

            // установка конфигурации подключения (аутенфикация по куки) для атрибутов Authorize иначе переброс на страницу входа
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login"); //редирект
                options.Cookie.MaxAge = new System.TimeSpan(30, 0, 0, 0); //макс. возраст куки (30 дней)
                options.Cookie.Name = "DreamChatCookie"; //название куки файла
            });

            //параметры временной блокировки из-за неуд.входа
            services.Configure<IdentityOptions>(options =>
            {
                //настройки блокировки пользователя при неудачном входе
                options.Lockout.DefaultLockoutTimeSpan = System.TimeSpan.FromMinutes(30); //повторно через 30 мин
                options.Lockout.MaxFailedAccessAttempts = 5; //макс. попытки входа
                options.Lockout.AllowedForNewUsers = false; //блокировка для новых пользователей

                //настройки для пароля
                options.Password.RequireDigit = true; //наличие цифр
                options.Password.RequiredLength = 6; //минимальная длина
                options.Password.RequireLowercase = true; //символы нижнего регистра
                options.Password.RequireUppercase = false; //символы верхнего регистра
                options.Password.RequiredUniqueChars = 0; //уникальных символов нет
                options.Password.RequireNonAlphanumeric = false; //нету символов,отличных от бук-циф
            });
        }
    }
}
