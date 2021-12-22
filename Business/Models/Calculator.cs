using Business.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Calculator
    {

        public enum Operations
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        public double Do(double val1, double val2, OperationBase operation)
        {
            return operation.CalculateResult(val1,val2);
        }
    }
    
    
}
