using Lab.Tp7.Common.Models;
using Lab.Tp7.Logic;
using System.Web.Mvc;

namespace Lab.Tp7.MVC.Controllers
{
    public class ShippersController : Controller
    {
        IShippersLogic shippersLogic = new ShippersLogic();
        public ActionResult Index()
        {
            return View(shippersLogic.GetAll());
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersModel shipperModel)
        {
            shippersLogic.Add(shipperModel);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id, string name, string phone)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Phone = phone;
            return View("~/Views/Shippers/Insert.cshtml");
        }

        [HttpPost]
        public ActionResult Update(int id,ShippersModel shipperModel)
        {
            shippersLogic.Update(id,shipperModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            shippersLogic.Delete(id);
            return RedirectToAction("Index","Shippers");
        }
    }
}