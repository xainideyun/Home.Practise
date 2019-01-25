using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M03_Decorate2.Code
{
    class CouponDecorate : OrderDecorate
    {
        public CouponDecorate(Order order) : base(order)
        {
        }

        public override void Decorate()
        {
            Order.Coupon = Program.Coupons.FirstOrDefault(a => a.OrderId == Order.Id);
            Console.WriteLine($"订单编号：{Order.Id}，优惠装饰成功");
            base.Decorate();
        }
    }
}
