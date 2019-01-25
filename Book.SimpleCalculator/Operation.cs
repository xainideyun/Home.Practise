using Book.CalculatorContract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.SimpleCalculator
{
    public class Operation : IOperation
    {
        public string Name { get; internal set; }

        public int NumberOperands { get; internal set; }
    }
}
