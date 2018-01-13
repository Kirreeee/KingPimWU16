using KingPim.Models;
using KingPim.Models.CategoriesViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KingPim.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
       
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CatalogId = new SelectList(db.Catalogs, "Id", "CatalogName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdCategoryViewModel adCategory)
        {
            if (ModelState.IsValid)
            {
                var newCategory = new Category();
                {
                    newCategory.CatalogName = adCategory.CatalogName;
                    newCategory.CategoryName = adCategory.Name;
                }

                db.Categories.Add(newCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}