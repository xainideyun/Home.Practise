using System;
using System.Collections.Generic;
using System.Text;

namespace Book.CalculatorContract
{
    public interface IOperation
    {
        string Name { get; }
        int NumberOperands { get; }
    }
}
