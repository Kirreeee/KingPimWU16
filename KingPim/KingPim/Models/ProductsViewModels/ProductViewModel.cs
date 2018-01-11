using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KingPim.Models.ProductsViewModels
{
    public class ProductViewModel
    {
        public List<Product>Product { get; set; }
        public List<Subcategory>SubCategory { get; set; }
        [Display(Name = "SubCategoryName")]
        public string Name { get; set; }
    }
}