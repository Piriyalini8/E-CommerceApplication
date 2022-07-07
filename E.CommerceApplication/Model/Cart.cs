using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E.CommerceApplication.Model
{
    public class Cart
    {
        public long CartId { get; set; }
        public long UserId { get; set; }
        public double total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
