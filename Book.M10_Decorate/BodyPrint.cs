using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Decorate
{
    public class BodyPrint : PrintOrder
    {
        public BodyPrint(Order order) : base(order)
        {
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"打印订单产品：{Order.Product}");
        }
    }
}
