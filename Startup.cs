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

        //����������� ��������
        public void ConfigureServices(IServiceCollection services)
        {
            //���������� �������� �� ������ �������� ������ ����������� � ��. ������
            services.AddDbContext<AppIdentityDbContext>();

            //���������� � ��������� ������� ������������� ��� ��� ����� UserIdentity � ����
            services.AddIdentity<UserIdentity,IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = true; // ���������� email
                opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // ���������� ������� (����� ��� �����)
                opts.SignIn.RequireConfirmedEmail = true; //������.�������������� �����
                opts.SignIn.RequireConfirmedEmail = true; //������ ���� ����������� �����
            }).AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders(); //���������������� ��������� �������

            // ��������� ������������ ����������� (������������ �� ����) ��� ��������� Authorize ����� �������� �� �������� �����
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => 
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login"); //��������
                    options.Cookie.MaxAge = new TimeSpan(30, 0, 0, 0); //����. ������� ���� (30 ����)
                    options.Cookie.Name = "DreamChatCookie"; //�������� ���� �����
                });

            //��������� ��������� ���������� ��-�� ����.�����
            services.Configure<IdentityOptions>(options =>
            {
                //��������� ���������� ������������ ��� ��������� �����
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30); //�������� ����� 30 ���
                options.Lockout.MaxFailedAccessAttempts = 5; //����. ������� �����
                options.Lockout.AllowedForNewUsers = false; //���������� ��� ����� �������������

                //��������� ��� ������
                options.Password.RequireDigit = true; //������� ����
                options.Password.RequiredLength = 6; //����������� �����
                options.Password.RequireLowercase = true; //������� ������� ��������
                options.Password.RequireUppercase = false; //������� �������� ��������
                options.Password.RequiredUniqueChars = 0; //���������� �������� ���
                options.Password.RequireNonAlphanumeric = false; //���� ��������,�������� �� ���-���
            });

            //���������� ��� ������������� �������� �������������
            services.AddTransient<AppUserManager>();

            //������� ��������� �������� ��� ������� ������� (��� ����� ������� ����� ���������)
            services.AddTransient<IViewRenderService, ViewRenderService>(); //������ �������� � html ��������
            services.AddTransient<IEmailService, EmailService>(); //������ ����� �������� ���������

            //��������� ������ SignalR � ���. ��������� ������
            services.AddSignalR(x => x.EnableDetailedErrors = true);

            //��������� ������������� MVC-�����������
            services.AddControllersWithViews();
        }

        //��������� ����������
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //���������� Middleware (������� �����):

            //���� ����� ������������
            if (env.IsDevelopment()) 
            {
                //����������� �������� � ���������� ��������
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //������������� �������� ��� ����������� ������ ��� �����
                app.UseExceptionHandler("/Home/Error");
            }

            //������������� ����������
            app.UseHttpsRedirection();

            //������������� ����������� ������ �� wwwroot
            app.UseStaticFiles();

            //������������� �������������
            app.UseRouting();

            //������������� ����������� � ������������
            app.UseAuthentication(); //��������������
            app.UseAuthorization(); //�����������

            //������ �������� 

            //�������������
            app.UseEndpoints(endpoints =>
            {
                //���.����� �������������
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //���. ����� ����������� � ����
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
