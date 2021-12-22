using Business.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class CalculatorWithHistory
    {
        public ValueInput Input { get; private set; }

        public double CalculatedResult()
        {
            double result = this.Input.Value;

            foreach(OperationBase op in this.Input.GetOperations())
            {
                result = op.CalculateResult(result);
            }
            return result;
        }
    }
}
