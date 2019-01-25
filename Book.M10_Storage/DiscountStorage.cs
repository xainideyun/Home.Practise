using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Storage
{
    class DiscountStorage : CashStorage
    {
        public double Discount { get; set; }
        public DiscountStorage(double discount)
        {
            this.Discount = discount;
        }

        public override double CalcResult(double money)
        {
            return money * Discount;
        }
    }
}
