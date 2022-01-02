using Business.Models;
using Business.Operations;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorWithHistory calc = new CalculatorWithHistory();
            calc.Add(4);
            calc.Add(new AddOperation(3));
            calc.Add(new MultiplyOperation(2));
            calc.Add(new AddOperation(6));

            double result = calc.CalculatedResult();           
            //Console.WriteLine(result);
            //Console.WriteLine(calc.GetInputs());
            Console.WriteLine(calc.GetOnlyAddOperationInputs());
            Console.WriteLine(calc.ContainsOperation(new AddOperation(3)));
        }
    }
}
