using Book.M03_Decorate2.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.M03_Decorate2
{
    /** 装饰模式2
     * 建立订单类
     * 将订单中的订单产品，订单优惠，订单配送属性依次装饰到类对象上
     * */
    class Program
    {
        public static List<Order> Orders;
        public static List<Coupon> Coupons;
        public static List<Product> Products;
        public static List<Freight> Freights;
        static void Main(string[] args)
        {
            Init();


            var order = Orders[2];
            var d1 = new ProductDecorate(order);
            var d2 = new FreightDecorate(d1);
            var d3 = new CouponDecorate(d2);
            d3.Decorate();
        }
        static void Init()
        {
            Orders = new List<Order> {
                new Order{ Id = 1, Amount = 20 },
                new Order{ Id = 2, Amount = 50 },
                new Order{ Id = 3, Amount = 33 }
            };
            Coupons = new List<Coupon> {
                new Coupon{ OrderId = 1, Amount = 10 },
                new Coupon{ OrderId = 2, Amount = 15 },
                new Coupon{ OrderId = 3, Amount = 9 }
            };
            Products = new List<Product> {
                new Product{ OrderId = 1, Amount = 10, Name = "回锅肉", Quantity = 2 },
                new Product{ OrderId = 1, Amount = 9, Name = "番茄炒蛋", Quantity = 2 },
                new Product{ OrderId = 2, Amount = 5, Name = "豆腐", Quantity = 1 },
                new Product{ OrderId = 3, Amount = 10, Name = "荠菜", Quantity = 66 },
                new Product{ OrderId = 3, Amount = 22, Name = "扬州炒饭", Quantity = 12 },
                new Product{ OrderId = 3, Amount = 20, Name = "干瘪藕丝", Quantity = 1 },
                new Product{ OrderId = 3, Amount = 10, Name = "回锅肉", Quantity = 100 }
            };
            Freights = new List<Freight> {
                new Freight{ OrderId = 1, Lat = 30.246, Lng = 114.98859, RefreshTime = DateTime.Now.AddDays(1) },
                new Freight{ OrderId = 1, Lat = 33.11452, Lng = 120.2256, RefreshTime = DateTime.Now.AddMilliseconds(90) },
                new Freight{ OrderId = 2, Lat = 31.452545, Lng = 114.98859, RefreshTime = DateTime.Now.AddMinutes(-1029) },
                new Freight{ OrderId = 2, Lat = 98.2312, Lng = 435.567481, RefreshTime = DateTime.Now.AddHours(99) },
                new Freight{ OrderId = 3, Lat = 222100, Lng = 768, RefreshTime = DateTime.Now.AddMonths(-131) },
                new Freight{ OrderId = 3, Lat = 30.246, Lng = 654789, RefreshTime = DateTime.Now.AddMonths(8831) },
                new Freight{ OrderId = 3, Lat = 65478567.5656, Lng = 114768765.98859, RefreshTime = DateTime.Now.AddTicks(1565656) },
            };
        }

    }
}
