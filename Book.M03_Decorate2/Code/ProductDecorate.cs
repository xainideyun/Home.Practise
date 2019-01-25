using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M03_Decorate2.Code
{
    class ProductDecorate : OrderDecorate
    {
        public ProductDecorate(Order order) : base(order)
        {
        }

        public override void Decorate()
        {
            Order.Products = Program.Products.Where(a => a.OrderId == Order.Id).ToList();
            Console.WriteLine($"订单编号：{Order.Id}，订单产品装饰成功");
            base.Decorate();
        }
    }
}
