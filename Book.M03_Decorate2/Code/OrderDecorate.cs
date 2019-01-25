using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M03_Decorate2.Code
{
    class OrderDecorate : Order
    {
        protected Order Order { get; set; }
        protected OrderDecorate DecorateObj { get; set; }
        public OrderDecorate(Order order)
        {
            if(order is OrderDecorate)
            {
                DecorateObj = order as OrderDecorate;
                Order = DecorateObj.Order;
                return;
            }
            Order = order;
        }

        public virtual void Decorate()
        {
            if(DecorateObj != null)
            {
                DecorateObj.Decorate();
            }
        }
    }
}
