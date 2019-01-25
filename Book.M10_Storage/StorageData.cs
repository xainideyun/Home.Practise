using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Storage
{
    class StorageData
    {
        public StorageData(StorageMode mode, params object[] parameters)
        {
            Mode = mode;
            Parameters = parameters;
        }
        public StorageMode Mode { get; set; }
        public object[] Parameters { get; set; }
        public override string ToString()
        {
            switch (Mode)
            {
                case StorageMode.Normal:
                    return "正常收款";
                case StorageMode.Return:
                    return $"满{Parameters[0]}减{Parameters[1]}";
                case StorageMode.Discount:
                    return $"{Convert.ToDouble(Parameters[0]) * 10}折";
                case StorageMode.Integral:
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
