using System;
using System.Collections.Generic;

namespace Book.CalculatorContract
{
    public interface ICalculator
    {
        double Operate(IOperation operation, params double[] numbers);
        IList<IOperation> GetOperations();
    }
}
