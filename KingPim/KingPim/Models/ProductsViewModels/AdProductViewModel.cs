using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KingPim.Models.ProductsViewModels
{
    public class AdProductViewModel
    {
        public Product Product { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public int SubcategoryId  { get; set; }




    }
}