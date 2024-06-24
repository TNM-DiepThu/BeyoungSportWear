using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.Entity.Base.EnumBase;

namespace BusinessLogicLayer.Viewmodels.Address
{
    public class AddressCreateVM
    {
        public string CreateBy { get; set; } = "admin";
        public string IDUser { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ParentID { get; set; }
        public AdressType AddressType { get; set; }
    }
}
