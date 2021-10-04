using System.Web;
using System.Web.Mvc;

namespace Lab.Tp8.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ExceptionFilter());
        }
    }
    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {

            var result = new ViewResult
            {
                ViewName = "~/Views/Error/Index.cshtml"
            };

            result.ViewData = new ViewDataDictionary<HandleErrorInfo>(filterContext.Controller.ViewData);
            result.ViewData.Add("Error", filterContext.Exception.Message);

            filterContext.Result = result;
            filterContext.ExceptionHandled = true;
        }
    }
}
