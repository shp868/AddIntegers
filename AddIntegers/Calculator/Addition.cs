using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddIntegers.Calculator
{
    public class Addition : ICalculator
    {
        public double Result(double number1, double number2)
        {
            Console.WriteLine("Result: {0}", number1 + number2);

            return number1 + number2;
        }
    }
}
