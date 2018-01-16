using KingPim.Models;
using KingPim.Models.SubcategoriesViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KingPim.Controllers
{
    public class SubcategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
     
        // GET: Subcategory
        public ActionResult Index()
        {
            var subcategoryList = new SubcategoryViewModel();
            {
                subcategoryList.Subcategory = db.Subcategories.ToList();
            }
            if (subcategoryList == null)
            {
                return HttpNotFound();
            }
            return View(subcategoryList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                db.Subcategories.Add(subcategory);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}