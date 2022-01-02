using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Operations
{
    public class AddOperation: OperationBase
    {
        public AddOperation(double value = 0):base("+",value)
        {

        }
        public override double CalculateResult(double val1)
        {
            return val1 + base.Value;
        }
        
    }
}
