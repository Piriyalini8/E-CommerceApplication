using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E.CommerceApplication.Model
{
    public class OrderItem
    {
        public long OrderItemId { get; set; }
        public long ProductId { get; set; }
        public long Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public long OrderId { get; set; }
    }
}
