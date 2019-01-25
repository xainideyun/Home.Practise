using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M03_Decorate2.Code
{
    class FreightDecorate : OrderDecorate
    {
        public FreightDecorate(Order order) : base(order)
        {
        }

        public override void Decorate()
        {
            Order.Freights = Program.Freights.Where(a => a.OrderId == Order.Id).ToList();
            Console.WriteLine($"订单编号：{Order.Id}，配送装饰成功");
            base.Decorate();
        }
    }
}
