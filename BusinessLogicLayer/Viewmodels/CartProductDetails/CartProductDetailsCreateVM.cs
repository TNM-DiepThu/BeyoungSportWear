using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.CartProductDetails
{
    public class CartProductDetailsCreateVM
    {
        public string CreateBy { get; set; }
        public Guid IDProductDetails { get; set; }
        public Guid IDCart { get; set; }
        public int Status { get; set; }
    }
}
