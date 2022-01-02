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
        private ValueInput Input { get; set; }

        public CalculatorWithHistory()
        {
            this.Input = new ValueInput(0);
        }
        public double CalculatedResult()
        {
            double result = this.Input.Value;

            foreach (OperationBase op in this.Input.GetOperations())
            {
                result = op.CalculateResult(result);
            }
            return result;
        }
        public void Add(double value)
        {
            this.Input = new ValueInput(value);
        }
        public void Add(OperationBase op)
        {
            this.Input.AddOperation(op);
        }

        public void AddValueToLastOperation(double value)
        {
            this.Input.GetOperations().Last().Value = value;
        }

        /// <summary>
        ///  TODO - Devolver en formato string, todos los inputs ingresados al momento
        ///  Formato: + 3 - 4 / 9
        /// </summary>
        /// <returns></returns>
        public string GetInputs()
        {            
            List<string> results = new List<string>();           
            foreach (OperationBase op in this.Input.GetOperations())
            {
                results.Add(op.Symbol);    
                results.Add(op.GetInput());               
            }           
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }
            return "";
        }

        /// <summary>
        /// TODO - Como el 'GetInputs()' pero solamente las operaciones de suma
        /// </summary>
        /// <returns></returns>
        public string GetOnlyAddOperationInputs()
        {
            List<string> results = new List<string>();           
            foreach (OperationBase op in this.Input.GetOperations())
            {
                if(op is AddOperation)
                {
                    results.Add(op.Symbol);
                    results.Add(op.GetInput());
                }              
            }
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }
            return "";
        }

        /// <summary>
        /// TODO - Devolver true si la 'operacion' esta contenida en la list de 'Operations'
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public Boolean ContainsOperation(OperationBase operation)
        {
            foreach (OperationBase op in this.Input.GetOperations())
            {
                if (op.Symbol.Equals(operation.Symbol))
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
