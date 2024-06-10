using DataAccessLayer.Entity.Base;
using static DataAccessLayer.Entity.Base.EnumBase;

namespace DataAccessLayer.Entity
{
    public partial class Order : EntityBase
    {
        public int HexCode { get; set; }
        public string? IDUser { get; set; }
        public string CustomerName { get; set; } = null!; // Tên khách hàng
        public string CustomerPhone { get; set; } = null!; // Số điện thoại khách hàng
        public string CustomerEmail { get; set; } = null!;// Địa chỉ email khách hàng
        public string ShippingAddress { get; set; } = null!;
        public string? ShippingAddressLine2 { get; set; }
        public DateTime ShipDate { get; set; } = DateTime.UtcNow.AddDays(3);
        public decimal TotalAmount { get; set; }
        public decimal? Cotsts { get; set; }
        public string? VoucherCode { get; set; }
        public string? Notes { get; set; }
        public bool TrackingCheck { get; set; } = false; // xáC NHẬN đơn hàng => sang hoá đơn
        public PaymentMethod PaymentMethods { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public ShippingMethod ShippingMethods { get; set; }
        public OrderStatus OrderStatus { get; set; }

        //public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; } 
        public virtual ICollection<OrderHistory>? OrderHistory { get; set; } 
       
    }
}
