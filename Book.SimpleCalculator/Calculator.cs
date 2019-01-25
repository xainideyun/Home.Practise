using Book.CalculatorContract;
using System;
using System.Collections.Generic;
using System.Composition;

namespace Book.SimpleCalculator
{
    [Export(typeof(ICalculator))]
    public class Calculator : ICalculator
    {
        public double Operate(IOperation operation, params double[] numbers)
        {
            switch (operation.Name)
            {
                case "+":
                    return numbers[0] + numbers[1];
                case "-":
                    return numbers[0] - numbers[1];
                case "*":
                    return numbers[0] * numbers[1];
                case "/":
                    return numbers[0] / numbers[1];
                default:
                    break;
            }
            return 0;
        }

        public IList<IOperation> GetOperations()
        {
            return new List<IOperation> {
                new Operation{ Name = "+", NumberOperands = 2 },
                new Operation{ Name = "-", NumberOperands = 2 },
                new Operation{ Name = "*", NumberOperands = 2 },
                new Operation{ Name = "/", NumberOperands = 2 }
            };            
        }

    }
}
