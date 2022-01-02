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
        public OperationBase(string symbol)
        {
            this.Symbol = symbol;            
        }
        /// <summary>
        /// Al ser abstract, obligamos a nuestras clases derivadas a implementar el método
        /// </summary>
        /// <param name="val1"></param>
        /// <returns></returns>
        public abstract double CalculateResult(double val1);
        /// <summary>
        /// Al ser virtual, pueden usar el método tal como está o hacer una implementación nue a
        /// </summary>
        public virtual string Symbol { get; init; }
        /// <summary>
        /// Al no ser ni virtual ni abstract, solamente se puede utilizar
        /// </summary>
        public double Value { get; set; }
        public virtual string GetInput()
        {
            return this.Value.ToString();
        }
    }
}
