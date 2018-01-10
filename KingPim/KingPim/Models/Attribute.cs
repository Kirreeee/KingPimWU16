using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingPim.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
        public virtual AttributeGroup AttributeGroup { get; set; }
        public int AttributeGroupId { get; set; }
    }
}