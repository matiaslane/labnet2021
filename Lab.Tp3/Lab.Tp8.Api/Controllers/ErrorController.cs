using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Tp8.Api.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index(string errorMessage)
        {
            ViewBag.Error = errorMessage;
            return View();
        }
    }
}