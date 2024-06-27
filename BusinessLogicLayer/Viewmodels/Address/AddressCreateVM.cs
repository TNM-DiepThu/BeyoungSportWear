using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.Address
{
    public class AddressCreateVM
    {
        public string CreateBy { get; set; } = null!;
        public string IDUser { get; set; }
        public string City { get; set; } = null!;//Thành phố
        public string DistrictCounty { get; set; } = null!;//Quận
        public string Commune { get; set; } = null!;//Xã
        public string SpecificAddress { get; set; } = null!;//Cụ thể
    }
}
