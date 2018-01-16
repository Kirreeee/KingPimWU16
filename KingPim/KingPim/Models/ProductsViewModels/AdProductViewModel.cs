using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingPim.Models.ProductsViewModels
{
    public class AdProductViewModel
    {
        public string ProdName { get; set; }
        public DateTime Created { get; set; }
        public string SubcategoryName { get; set; }
        public string Descriptions { get; set; }
    }
}