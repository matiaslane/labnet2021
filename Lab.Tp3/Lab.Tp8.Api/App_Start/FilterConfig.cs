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
            var result = filterContext.HttpContext.Response.StatusCode;
        }
    }
}
