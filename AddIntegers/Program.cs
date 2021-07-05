using AddIntegers.Models;
using AddIntegers.Calculator;
using System;

namespace AddIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Values Value = new Values();
            Addition Add = new Addition();

            Console.WriteLine("Enter first number: ");
            Value.Number1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            Value.Number2 = Convert.ToDouble(Console.ReadLine());

            Add.Result(Value.Number1, Value.Number2);

            Console.ReadLine();            
        }
    }
}
