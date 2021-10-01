using System.Web.Mvc;

namespace Lab.Tp7.MVC.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index(string errorMessage)
        {
            ViewBag.Message = errorMessage;
            return View();
        }

    }
}