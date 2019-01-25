using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Storage
{
    class CashContext
    {
        private CashStorage _storage;
        public CashContext(StorageData mode)
        {
            switch (mode.Mode)
            {
                case StorageMode.Normal:
                    _storage = new NormalStorage();
                    break;
                case StorageMode.Return:
                    _storage = new ReturnStorage(Convert.ToDouble(mode.Parameters[0]), Convert.ToDouble(mode.Parameters[1]));
                    break;
                case StorageMode.Discount:
                    _storage = new DiscountStorage((double)mode.Parameters[0]);
                    break;
                default:
                    break;
            }
        }

        public double CashResult(double money)
        {
            return _storage.CalcResult(money);
        }

    }
}
