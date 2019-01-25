using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M10_Decorate
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order { Id = 1, Product = "红烧牛肉面", Quantity = 2 };
            var title = new TitlePrint(order);
            var body = new BodyPrint(title);
            body.Print();
        }
    }
}
