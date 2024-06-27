using BusinessLogicLayer.Viewmodels.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.ApplicationUser
{
    public class RegisterUser
    {
        public Guid Id { get; set; } = new Guid();
        public string FirstAndLastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public int Status { get; set; } = 1;
        public ICollection<AddressCreateVM>? AddressCreateVM { get; set; }
    }
}
