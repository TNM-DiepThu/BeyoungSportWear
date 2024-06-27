using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Viewmodels.ApplicationUser
{
    public class UserUpdateVM
    {
        public string? FirstAndLastName { get; set; } 
        public string? Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public int? Gender { get; set; }
        public IFormFile? Images { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
