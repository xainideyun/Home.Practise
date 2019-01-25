using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M04_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { 1111, 2, 3.12, 5, 67, 87, 87, 9 };
            var factory = new MinusFactory();
            var oper = factory.CreateOperator();
            var result = oper.GetResult(nums);
            Console.WriteLine(result);

        }
    }
}
