using Lab.Tp7.Logic;
using System.Web.Mvc;

namespace Lab.Tp7.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        public ActionResult Index()
        {
            ICategoriesLogic categoriesLogic = new CategoriesLogic();

            return View(categoriesLogic.GetAll());
        }
    }
}