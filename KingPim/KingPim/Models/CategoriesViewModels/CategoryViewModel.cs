using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KingPim.Models.CategoriesViewModels
{
    public class CategoryViewModel
    {
      public List<Category>Category { get; set; }
      public List<Catalog>Catalog { get; set; }
      
    }
}