using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KingPim.Models
{
    public class ReadOnlyAttribute
    {
        
        public int ReadOnlyAttributeId { get; set; }
        public int Version { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Created { get; set; }
        [JsonIgnore]
        public DateTime LastModified { get; set; }
        public bool Published { get; set; }
        public List<Product> Product { get; set; }

    }
}