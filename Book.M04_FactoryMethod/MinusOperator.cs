using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M04_FactoryMethod
{
    class MinusOperator : IOperator
    {
        public double GetResult(params double[] nums)
        {
            var first = nums[0];
            var others = nums.ToList();
            others.RemoveAt(0);
            return first - others.Sum();
        }
    }
}
