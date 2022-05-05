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

        //����������� ��������
        public void ConfigureServices(IServiceCollection services)
        {
            //����������� �������� �� ��. ������
            services.AddMessengerServices();
        }

        //��������� ����������
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //���� ����� ������������
            if (env.IsDevelopment()) 
            {
                //����������� �������� � ���������� ��������
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //������������� �������� ��� ����������� ������ ��� �����
                app.UseStatusCodePagesWithReExecute("/Home/Error");
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
