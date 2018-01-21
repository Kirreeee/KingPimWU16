using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingPim.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public int SubcategoryId { get; set; }
        public DateTime Created { get; set; }
    }
}