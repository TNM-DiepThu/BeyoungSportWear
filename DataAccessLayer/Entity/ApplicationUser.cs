using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Entity
{
    public partial class ApplicationUser : IdentityUser
    {
        public string FirstAndLastName { get; set; } = null!;
        public string? Address { get; set; }
        public int Status { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Address>? Addresss { get; set; }
        public virtual ICollection<VoucherUser> VoucherUser { get; set; } = null!;
        public virtual Cart Cart { get; set; }
    }
}
