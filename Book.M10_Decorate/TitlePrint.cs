using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Decorate
{
    public class TitlePrint : PrintOrder
    {
        public TitlePrint(Order order) : base(order)
        {
            
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"开始打印订单标题：订单id#{Order.Id}");
        }
    }
}
