using Book.UtilPractice.Code;
using System;
using System.Xml.Linq;

namespace Book.UtilPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //M1();
            M2();

            Console.Read();
        }

        static void M1()
        {
            var d = new MyXDocument();
            //d.M1();
            //d.M2();
            d.M3();

        }

        static void M2()
        {
            var d = new MyJson();
            //d.M1();
            //d.M2();
            d.M3();
        }



    }
}
