using BusinessLogicLayer.Viewmodels.OrderDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.Entity.Base.EnumBase;

namespace BusinessLogicLayer.Viewmodels.Order
{
    public class OrderCreateVM
    {
        public string CreateBy { get; set; }
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
        public int Status { get; set; } = 1; 
        public List<OrderDetailsCreateVM> OrderDetailsCreateVM { get; set; }

        public int GenerateHexCode()
        {
            var now = DateTime.Now;
            var dateString = now.ToString("yyyyMMdd");

            var random = new Random();
            var randomPart = random.Next(1000, 9999);

            var hexString = dateString + randomPart.ToString();

            if (int.TryParse(hexString, out int hexCode))
            {
                return hexCode;
            }
            else
            {
                randomPart = random.Next(100, 999);
                hexString = dateString.Substring(2) + randomPart.ToString();
                return int.Parse(hexString);
            }
        }
    }
}
