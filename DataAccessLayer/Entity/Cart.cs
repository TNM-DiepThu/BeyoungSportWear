using DataAccessLayer.Entity.Base;

namespace DataAccessLayer.Entity
{
    public partial class Cart : EntityBase
    {
        public string? Description { get; set; }
        public string? IDUser { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; } = null!;
        public virtual ICollection<CartProductDetails>? CartProductDetails { get; set; } 
    }
}
