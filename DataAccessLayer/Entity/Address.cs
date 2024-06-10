using DataAccessLayer.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public partial class Address : EntityBase
    {
        public string IDUser { get; set; } 
        public string City { get; set; }
        public string DistrictCounty { get; set; }
        public string Commune { get; set; }
        public string SpecificAddress { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
