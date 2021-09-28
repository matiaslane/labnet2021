using Lab.Tp7.Logic;
using Lab.Tp7.MVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace Lab.Tp7.MVC.Controllers
{
    public class ShippersController : Controller
    {
        public ActionResult Index()
        {
            var shippersLogic = new ShippersLogic();
            var shippers = shippersLogic.GetAll();
            var shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return View(shippersView);
        }
    }
}