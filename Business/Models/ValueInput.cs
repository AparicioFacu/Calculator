using Business.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class ValueInput
    {
        public ValueInput()
        {
           
        }
        public ValueInput(double value)
        {
            this.Value = value;
            this.Operations = new List<OperationBase>();
        }

        public double Value { get; set; }

        private List<OperationBase> Operations { get; set; }
        public List<double> Values { get; set; }

        public void AddOperation(OperationBase op)
        {
            if(op == null)
            {
                throw new Exception("op no puede ser null");
            }
            this.Operations.Add(op);
        }
        public List<OperationBase> GetOperations()
        {
            return this.Operations;
        }
    }
}
