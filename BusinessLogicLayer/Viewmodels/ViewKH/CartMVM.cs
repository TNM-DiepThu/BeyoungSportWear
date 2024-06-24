using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.ViewKH
{
    public class CartProductDetailsViewModel
    {
        public Guid IDProductDetails { get; set; }
        public int Quantity { get; set; }
    }
    public class CartMVM
    {
        public string Description { get; set; }
        public string IDUser { get; set; }
        public List<CartProductDetailsViewModel> CartProductDetails { get; set; }

    }

   
}
