using KingPim.Models;
using KingPim.Models.AttributeGroupsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KingPim.Controllers
{
    public class AttributeGroupController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AttributeGroup
        public ActionResult Index()
        {
            var attributeGroupList = new AttributeGroupViewModel();
            {
                attributeGroupList.AttributeGroup = db.AttributeGroups.ToList();
            }

            return View(attributeGroupList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AdAttributeGroupViewModel adAttributeGroup)
        {
            if (adAttributeGroup != null)
            {
                if (ModelState.IsValid)
                {
                    var newAttributeGroup = new AttributeGroup();
                    {
                        newAttributeGroup.AttributeGroupName = adAttributeGroup.AttributeGroupName;
                    }

                    db.AttributeGroups.Add(newAttributeGroup);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            return View();
        }



    }
}