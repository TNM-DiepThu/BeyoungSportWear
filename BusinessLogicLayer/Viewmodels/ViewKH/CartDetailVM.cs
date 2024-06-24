using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.ViewKH
{
    public class GetCartDetailVM
    {
        public Guid? Id { get; set; }
        public Guid IdUser { get; set; }
        public Guid? IDProductDetails { get; set; }
        public Guid IdCart { get; set; }
        public int Quantity { get; set; }

        public string? Url { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }         
    }
}
