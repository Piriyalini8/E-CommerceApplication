using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E.CommerceApplication.Model
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public long AvailableQuantity { get; set; }
        public bool Featured { get; set; }
        public bool TopSelling { get; set; }
        public string ImageUrl { get; set; }   
    }
}
