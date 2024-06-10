using DataAccessLayer.Entity.Base;
namespace DataAccessLayer.Entity
{
    public partial class CartProductDetails : NoIDEntityBase
    {
        public Guid IDProductDetails { get; set; }
        public Guid IDCart { get; set; }

        public virtual ProductDetails ProductDetails { get; set; } = null!;
        public virtual Cart Cart { get; set; } = null!;
    }
}
