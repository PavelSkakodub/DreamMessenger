using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;

namespace DreamMessenger.Services
{
    //интерфейс для сервиса
    public interface IViewRenderService 
    {
        //метод возврата представления с моделью как html
        Task<string> RenderToStringAsync(string viewName, object model); 
    }

    //сервис чтения представления с моделью (для Email отправки)
    public class ViewRenderService : IViewRenderService
    {
        private readonly IRazorViewEngine _razorViewEngine; //отвечает за воспроизведение представлений 
        private readonly ITempDataProvider _tempDataProvider; //определяет контракт для поставщиков временных данных, хранящих данные, которые просматриваются при следующем запросе
        private readonly HttpContext _httpContext; //содержит всю информацию о HTTP-запросе

        public ViewRenderService(IRazorViewEngine razorViewEngine,ITempDataProvider tempDataProvider,IHttpContextAccessor httpContextAccessor)
        {
            //инициализация объектов интерфейсных классов
            _razorViewEngine = razorViewEngine;
            _tempDataProvider = tempDataProvider;
            _httpContext = httpContextAccessor.HttpContext;
        }

        //конвертер который получает имя представления и связанную модель и возвращает строку html-страницы
        public async Task<string> RenderToStringAsync(string viewName, object model)
        {
            //Объект контекста для выполнения действия, выбранного в составе HTTP-запроса
            //с передачей RouteData (Сведения о текущем пути маршрутизации) и ActionDescriptor (Опис-ие действия MVC)
            var actionContext = new ActionContext(_httpContext, new RouteData(), new ActionDescriptor());

            //находим представление по указанному названию
            var viewEngineResult = _razorViewEngine.FindView(actionContext, viewName, false);

            //если представления не найдено выдаём ошибку
            if (viewEngineResult.View == null || (!viewEngineResult.Success))
            {
                throw new ArgumentNullException($"Unable to find view '{viewName}'");
            }

            //считываем найденное представление
            var view = viewEngineResult.View;

            //используем поток записи строк
            using var sw = new StringWriter();

            //создаём контейнер для передачи данных между контроллером и представлением
            var viewDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
            {
                Model = model //передаём модель в контейнер
            };

            //набор данных, существующий только в течение времени от одного запроса до другого
            var tempData = new TempDataDictionary(_httpContext, _tempDataProvider);

            //сведения, относящиеся к визуализации представления (здесь идёт запись страницы в поток)
            var viewContext = new ViewContext(actionContext, view, viewDictionary, tempData, sw, new HtmlHelperOptions())
            {
                RouteData = _httpContext.GetRouteData()   //задаём данные маршрута
            };

            //визуализация представления с его новыми данными
            await view.RenderAsync(viewContext);

            //возвращаем строковый поток как строку
            return sw.ToString();
        }
    }
}
