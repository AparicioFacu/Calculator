using System;
using Business.Models;
using Business.Operations;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            OperationBase op = new AddOperation();
            double result = calc.Do(2, 3, op);
            Console.WriteLine(result);
        }
    }
}
