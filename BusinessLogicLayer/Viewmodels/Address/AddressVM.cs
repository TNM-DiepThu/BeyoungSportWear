using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.Address
{
    public class AddressVM
    {
        public Guid ID { get; set; }
        public string IDUser { get; set; }
        public string? Province { get; set; }
        public string? Ward { get; set; }
        public string? District { get; set; }
        public string? RoadNum { get; set; }

        public int Status { get; set; }
    }
}
