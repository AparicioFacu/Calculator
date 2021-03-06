using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Operations
{
    public class DivideOperation : OperationBase
    {
        public DivideOperation(double value) : base("/", value)
        {

        }
        public DivideOperation() : base("/")
        {

        }
        public override double CalculateResult(double val1)
        {
            return val1 / base.Value;
        }
    }
}
