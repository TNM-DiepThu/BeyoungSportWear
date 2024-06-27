using DataAccessLayer.Entity.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public partial class Address : EntityBase
    {
        public string IDUser { get; set; }

        public string MainAddress { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
