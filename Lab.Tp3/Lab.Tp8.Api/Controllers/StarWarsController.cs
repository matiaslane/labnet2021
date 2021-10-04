using Lab.Tp3.Logic;
using System.Web.Mvc;

namespace Lab.Tp8.Api.Controllers
{
    public class StarWarsController : Controller
    {
        public ActionResult Index()
        {
            IStarWarsLogic repoSw = new StarWarsLogic();
            return View(repoSw.GetPeople());
        }
    }
}