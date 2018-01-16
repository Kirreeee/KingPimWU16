﻿using KingPim.Models;
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
            var categoryList = new CategoryViewModel();
            {
                categoryList.Category = db.Categories.ToList();
            }
            if (categoryList == null)
            {
                return HttpNotFound();

            }
            return View(categoryList);
           
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CatalogId = new SelectList(db.Catalogs, "Id", "CatalogName");
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.CatalogId = new SelectList(db.Catalogs, "Id", "CatalogName", category.CatalogId);

            return View();
        }
    }
}