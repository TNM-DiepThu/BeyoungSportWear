using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.ViewKH
{
    public class ProDetailKH
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<string> Size { get; set; }
        public List<string> Color { get; set; }
        public string UrlImg { get; set; }
    }
}
