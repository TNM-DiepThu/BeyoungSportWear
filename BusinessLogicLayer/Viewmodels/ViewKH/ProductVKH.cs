using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.ViewKH
{
    public class ProductVKH
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal CostPrie { get; set; }
        public string urlImg { get; set; }
    }
}
