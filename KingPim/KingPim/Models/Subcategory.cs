using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingPim.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string SubcateoryName { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Product> Product { get; set; }
    }
}