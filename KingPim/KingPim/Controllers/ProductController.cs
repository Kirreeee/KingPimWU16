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
            ViewBag.SubcategoryId = new SelectList(db.Subcategories, "Id", "SubcategoryId");
            return View();
        }

        [HttpPost]
        public ActionResult Create(AdProductViewModel Adproduct)
        {
            if (ModelState.IsValid)
            {
                
                var newProduct = new Product();
                {
                    newProduct.ProductName = Adproduct.ProdName;
                    //newProduct.SubCategoryName = Adproduct.SubcategoryName;
                    newProduct.Description = Adproduct.Descriptions;
                    newProduct.Created = DateTime.Now;
                }

                

                db.Products.Add(newProduct);
                db.SaveChanges();

                RedirectToAction("Index");
            }

            return View();
        }
    }
}