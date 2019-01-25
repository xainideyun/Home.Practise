using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M04_FactoryMethod
{
    interface IOperator
    {
        double GetResult(params double[] nums);
    }
}
