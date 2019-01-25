using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Storage
{
    class ReturnStorage : CashStorage
    {
        public double FullAmount { get; set; }
        public double MinusAmount { get; set; }

        public ReturnStorage(double fullAmount, double minusAmount)
        {
            this.FullAmount = fullAmount;
            this.MinusAmount = minusAmount;
        }
        public override double CalcResult(double money)
        {
            if (money >= FullAmount)
                return money - Math.Floor(money / FullAmount) * MinusAmount;
            return money;
        }
    }
}
