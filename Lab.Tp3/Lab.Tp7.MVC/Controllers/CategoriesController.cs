using Lab.Tp7.Entities;
using Lab.Tp7.Logic;
using Lab.Tp7.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Tp7.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        public ActionResult Index()
        {
            var categoriesLogic = new CategoriesLogic();
            List<Categories> categories = categoriesLogic.GetAll();
            List<CategoriesView> categoriesViews = categories.Select(c => new CategoriesView
            {
                Id = c.CategoryID,
                Name = c.CategoryName,
                Description = c.Description
            }).ToList();

            return View(categoriesViews);
        }
    }
}