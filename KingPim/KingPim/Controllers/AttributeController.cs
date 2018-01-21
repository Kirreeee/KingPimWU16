using KingPim.Models;
using KingPim.Models.AttributeViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KingPim.Controllers
{
    public class AttributeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Attribute
        public ActionResult Index()
        {
            var attributeList = new AttributeViewModel();
            {
                attributeList.Attribute = db.Attributes.ToList();
                attributeList.AttributeGroup = db.AttributeGroups.ToList();
            }

            if (attributeList == null)
            {
                return HttpNotFound();
            }

            return View(attributeList);

        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.AttributeGroupId = new SelectList(db.AttributeGroups, "Id", "AttributeGroupName");
            return View();
        }

        public ActionResult Create(AdAttributeViewModel adAttribute)
        {
            if (adAttribute != null)
            {
                if (ModelState.IsValid)
                {

                    var newAttribute = new Models.Attribute();
                    {
                        newAttribute.AttributeName = adAttribute.AttributeName;
                        newAttribute.AttributeGroupId = adAttribute.AttributeGroupId;
                       
                    }

                    db.Attributes.Add(newAttribute);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            return View();
        }


    }
}