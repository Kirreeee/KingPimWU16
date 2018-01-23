using KingPim.Models;
using KingPim.Models.ProductsViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
        protected UserManager<ApplicationUser> UserManager { get; set; }

        public ProductController()
        {
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.db));

        }

        // GET: Product
        public ActionResult Index()
        {
            var productList = new ProductViewModel();
            {
                productList.Product = db.Products.ToList();
            }

            if (productList.Product == null)
            {
                return HttpNotFound();
            }

            return View(productList);
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
                if(Adproduct != null)
                {
                    
                    //Add new ReadOnlyAttribute
                    var newReadOnlyAttribute = new ReadOnlyAttribute();
                    {
                        var user = User.Identity.GetUserName();
                        newReadOnlyAttribute.LastModified = DateTime.Now;
                        newReadOnlyAttribute.Created = DateTime.Now;
                        newReadOnlyAttribute.Version = 0;
                    }
                  

                    db.ReadOnlyAttribute.Add(newReadOnlyAttribute);
                    db.SaveChanges();
                    
                    //Add new Product
                    Adproduct.Product.ReadOnlyAttributeId = newReadOnlyAttribute.ReadOnlyAttributeId;
                    Adproduct.Product.Created = DateTime.Now;
                    Adproduct.Product.SubcategoryId = Adproduct.SubcategoryId;

                    db.Products.Add(Adproduct.Product);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

               
            }


            return View();
        }
    }
}