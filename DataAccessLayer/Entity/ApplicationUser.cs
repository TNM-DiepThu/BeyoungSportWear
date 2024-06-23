using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Entity
{
    public partial class ApplicationUser : IdentityUser
    {
        public string ImageUrl { get; set; }
        public string FirstAndLastName { get; set; } = null!;
        public int Sex { get; set; }
        public string Address { get; set; } = null!;
        public int Status { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Address> Addresss { get; set; }
        public virtual ICollection<VoucherUser> VoucherUser { get; set; } = null!;
        public virtual Cart Cart { get; set; }
    }
}
