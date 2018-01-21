using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KingPim.Models.AttributeViewModels
{
    public class AdAttributeViewModel
    {
        [Required]
        public string AttributeName { get; set; }
        public int AttributeGroupId { get; set; }
    }
}