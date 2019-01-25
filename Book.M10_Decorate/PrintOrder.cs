using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Decorate
{
    public class PrintOrder : Order
    {
        protected Order Order { get; set; }
        protected PrintOrder Decorator { get; set; }
        public PrintOrder(Order order)
        {
            if(order is PrintOrder)
            {
                Decorator = order as PrintOrder;
                Order = Decorator.Order;
            }
            else
            {
                Order = order;
            }
        }
        public override void Print()
        {
            if(Decorator != null)
            {
                Decorator.Print();
            }
            else
            {
                Order.Print();
            }
        }
    }
}
