using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KingPim.Models.CatalogsViewModels
{
    public class CatalogsViewModel
    {
        public List<Catalog>Catalog { get; set; }
        [Display(Name = "Katalog namn")]
        public string Name { get; set; }
        public List<Subcategory>Subcateogry { get; set; }
        [Display(Name = "SubKategori namn")]
        public string SubCategoryName { get; set; }
        public List<Category>Category { get; set; }
        [Display(Name = "Kategori namn")]
        public string CategoryName { get; set; }


    }
}