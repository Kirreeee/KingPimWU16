using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingPim.Models
{
    public class SystemReadOnlyAttribute
    {
        public int Id { get; set; }
        public DateTime LastModified { get; set; }
        public virtual ApplicationUser ModifiedBy { get; set; }
        public int VersionNumber { get; set; }
        public bool Published { get; set; }
        public DateTime Created { get; set; }
    }
}