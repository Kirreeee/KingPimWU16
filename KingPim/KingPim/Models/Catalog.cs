using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingPim.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string CatalogName { get; set; }
        public List<Subcategory> SubCategory { get; set; }
        public List<Category> Category { get; set; }
    }
}