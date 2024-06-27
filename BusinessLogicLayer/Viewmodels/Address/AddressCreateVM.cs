using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using DataAccessLayer.Entity;

namespace BusinessLogicLayer.Viewmodels.Address
{
    public class AddressCreateVM
    {
        public string CreateBy { get; set; } = "admin";
        public string IDUser { get; set; }
        public string MainAddress { get; set; }

    }
}
