using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            //подключение сервисов из др. класса
            services.AddMessengerServices();
        }

        //настройки приложения
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //если режим разработчика
            if (env.IsDevelopment()) 
            {
                //подключение страницы с подробными ошибками
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //использование страницы для отображения ошибки для юзера
                app.UseStatusCodePagesWithReExecute("/Home/Error");
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
