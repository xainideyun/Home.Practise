using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Decorate
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Product { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("打印小票");
        }
    }
}
