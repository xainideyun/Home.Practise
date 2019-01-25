using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M03_Decorate2
{
    class Order
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public List<Product> Products { get; set; }
        public Coupon Coupon { get; set; }
        public List<Freight> Freights { get; set; }
    }
}
