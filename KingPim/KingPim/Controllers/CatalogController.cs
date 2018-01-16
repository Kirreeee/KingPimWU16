using KingPim.Models;
using KingPim.Models.CatalogsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KingPim.Controllers
{
    public class CatalogController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: Catalog
        public ActionResult Index()
        {
            var catalogList = new CatalogViewModel();
            {
                catalogList.Catalog = db.Catalogs.ToList();
            }
            return View(catalogList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(AdCatalogViewModel adCatalog)
        {
            if (ModelState.IsValid)
            {
                var newCatlog = new Catalog();
                {
                    newCatlog.CatalogName = adCatalog.CatalogName;
                }

                db.Catalogs.Add(newCatlog);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}