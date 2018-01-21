using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingPim.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual Catalog Catalog { get; set; }
        public int CatalogId { get; set; }
        public List<Subcategory> SubCategory { get; set; }
        public bool Published { get; set; }

    }
}