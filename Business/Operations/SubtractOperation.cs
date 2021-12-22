using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Operations
{
    public class SubtractOperation: OperationBase
    {
        public SubtractOperation(double value) : base("-", value)
        {

        }
        public override double CalculateResult(double val1)
        {
            return val1 - base.Value;
        }
    }
}
