using KingPim.Models;
using KingPim.Models.ProductsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KingPim.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
       
        // GET: Product
        public ActionResult Index()
        {
            var products = new ProductViewModel();
            {
                products.Product = db.Products.ToList();
            }
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.SubcategoryId = new SelectList(db.Subcategories, "Id", "SubcateoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(AdProductViewModel Adproduct)
        {
            if (ModelState.IsValid)
            {
                
                var newProduct = new Product();
                {
                    newProduct.ProductName = Adproduct.Product.ProductName;
                    newProduct.SubcategoryId = Adproduct.SubcategoryId;
                    newProduct.Description = Adproduct.Product.Description;
                    newProduct.Created = DateTime.Now;
                }

                db.Products.Add(newProduct);
                db.SaveChanges();

               return RedirectToAction("Index");
            }


            return View();
        }
    }
}