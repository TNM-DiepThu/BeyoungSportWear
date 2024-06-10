using DataAccessLayer.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public partial class Voucher : EntityBase
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public Types Type { get; set; }
        public int MinimumAmount { get; set; }
        public decimal ReducedValue { get; set; }
        public bool IsActive { get; set; }
        public enum Types
        {
            Percent,
            Cash,
        }
        public virtual ICollection<VoucherUser> VoucherUser { get; set; } = null!;
    }
}
