using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KingPim.Models.AttributeGroupsViewModels
{
    public class AdAttributeGroupViewModel
    {
        [Required]
        public string AttributeGroupName { get; set; }
    }
}