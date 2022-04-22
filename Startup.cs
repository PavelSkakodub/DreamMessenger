using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DreamMessenger.Data;
using DreamMessenger.Models;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using DreamMessenger.Services;
using DreamMessenger.Hubs;
using Microsoft.Extensions.Hosting;

namespace DreamMessenger
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //подключение сервисов
        public void ConfigureServices(IServiceCollection services)
        {
            //подключаем контекст БД внутри которого строка подключения и пр. данные
            services.AddDbContext<AppIdentityDbContext>();

            //добавление и настройка системы идентификации под наш класс UserIdentity и роль
            services.AddIdentity<UserIdentity,IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = true; // уникальный email
                opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // допустимые символы (любое имя юзера)
                opts.SignIn.RequireConfirmedEmail = true; //обязат.подтвержденный емейл
                opts.SignIn.RequireConfirmedEmail = true; //должен быть подтверждеён емейл
            }).AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders(); //функциональность генерации токенов

            // установка конфигурации подключения (аутенфикация по куки) для атрибутов Authorize иначе переброс на страницу входа
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => 
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login"); //редирект
                    options.Cookie.MaxAge = new TimeSpan(30, 0, 0, 0); //макс. возраст куки (30 дней)
                    options.Cookie.Name = "DreamChatCookie"; //название куки файла
                });

            //параметры временной блокировки из-за неуд.входа
            services.Configure<IdentityOptions>(options =>
            {
                //настройки блокировки пользователя при неудачном входе
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30); //повторно через 30 мин
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

            //подключаем наш реализованный менеджер пользователей
            services.AddTransient<AppUserManager>();

            //сервисы создаются единожды для каждого запроса (при новом запросе опять создаются)
            services.AddTransient<IViewRenderService, ViewRenderService>(); //сервис конверта в html страницу
            services.AddTransient<IEmailService, EmailService>(); //сервис емейл отправки сообщений

            //добавляем сервис SignalR с вкл. подробных ошибок
            services.AddSignalR(x => x.EnableDetailedErrors = true);

            //добавляем использование MVC-архитектуры
            services.AddControllersWithViews();
        }

        //настройки приложения
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //компоненты Middleware (порядок важен):

            //если режим разработчика
            if (env.IsDevelopment()) 
            {
                //подключение страницы с подробными ошибками
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //использование страницы для отображения ошибки для юзера
                app.UseExceptionHandler("/Home/Error");
            }

            //использование редиректов
            app.UseHttpsRedirection();

            //использование статических файлов из wwwroot
            app.UseStaticFiles();

            //использование маршрутизации
            app.UseRouting();

            //использование авторизации и аутенфикации
            app.UseAuthentication(); //аутентификация
            app.UseAuthorization(); //авторизация

            //другие маршруты 

            //маршрутизация
            app.UseEndpoints(endpoints =>
            {
                //кон.точка маршрутизации
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //кон. точка подключения к хабу
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
