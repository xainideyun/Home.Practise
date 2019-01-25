using Book.CalculatorContract;
using Book.SimpleCalculator;
using System;
using System.Composition;
using System.Composition.Hosting;
using System.Linq;

namespace Book.Composition
{
    class Program
    {
        [Import]
        public ICalculator Calculator { get; set; }
        static void Main(string[] args)
        {
            var p = new Program();
            p.Bootstrap();
            p.Run();

        }

        public void Bootstrap()
        {
            var configuration = new ContainerConfiguration().WithPart<Calculator>();
            using (var host = configuration.CreateContainer())
            {
                host.SatisfyImports(this);
            }
        }

        public void Run()
        {
            var operators = Calculator.GetOperations();
            Console.WriteLine("本程序包含以下操作：");
            foreach (var item in operators)
            {
                Console.WriteLine($"操作符：{item.Name}，操作数：{item.NumberOperands}");
            }
            Console.WriteLine("---------------------------");
            var sign = string.Empty;
            do
            {
                Console.WriteLine("请输入操作符...");
                sign = Console.ReadLine();
                var operation = operators.FirstOrDefault(a => a.Name == sign);
                if(operation == null)
                {
                    Console.WriteLine("操作符输入错误，运算终止！");
                    continue;
                }
                var numbers = new double[2];
                for (int i = 1; i <= operation.NumberOperands; i++)
                {
                    Console.WriteLine($"请输入数字[{i}]：");
                    numbers[i - 1] = double.Parse(Console.ReadLine());
                }
                var result = Calculator.Operate(operation, numbers);
                Console.WriteLine($"计算结果：{result}");

            } while (sign != "exit");

        }

    }
}
