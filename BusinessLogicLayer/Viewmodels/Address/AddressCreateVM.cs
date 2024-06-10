using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.Address
{
    public class AddressCreateVM
    {
        public string CreateBy { get; set; }
        public string IDUser { get; set; }
        public string City { get; set; }
        public string DistrictCounty { get; set; }
        public string Commune { get; set; }
        public string SpecificAddress { get; set; }
        public int Status { get; set; }
    }
}
