using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingPim.Models.ProductsViewModels
{
    public class AdCategoryViewModel
    {
        public int Id { get; set; }
        public List<Catalog>Catalog { get; set; }
        public List<Category>Category { get; set; }
        public string CategoryName { get; set; }
        public string CatalogName { get; set; }
        public int CatalogId { get; set; }
    }
}