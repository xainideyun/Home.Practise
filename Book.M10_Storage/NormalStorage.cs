using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Storage
{
    class NormalStorage : CashStorage
    {
        public override double CalcResult(double money)
        {
            return money;
        }
    }
}
