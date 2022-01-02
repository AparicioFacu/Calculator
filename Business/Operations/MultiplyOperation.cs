using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Operations
{
    public class MultiplyOperation: OperationBase
    {
        public MultiplyOperation(double value) : base("*", value)
        {

        }
        public MultiplyOperation() : base("*")
        {

        }
        public override double CalculateResult(double val1)
        {
            return val1 * base.Value;
        }
    }
}
