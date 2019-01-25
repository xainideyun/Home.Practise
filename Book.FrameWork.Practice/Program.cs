using Book.FrameWork.Practice.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.FrameWork.Practice
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            M1();
            Console.Read();
        }

        static void M1()
        {
            var c = new MyWpf();
            c.M1();
        }
    }
}
