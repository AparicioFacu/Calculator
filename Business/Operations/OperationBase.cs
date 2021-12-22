using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Operations
{
    public abstract class OperationBase
    {
        public OperationBase(string symbol, double value)
        {
            this.Symbol = symbol;
            this.Value = value;
        }
        public abstract double CalculateResult(double val1);        
        public virtual string Symbol { get; init; }
        public double Value { get; init; }
    }
}
