using Business.Models;
using Business.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    class CalculatorViewModel
    {
        private CalculatorWithHistory _calculator;
        private Boolean _firtValue;
        public CalculatorViewModel()
        {
            this._firtValue = true;
            this._calculator = new CalculatorWithHistory();
        }

        public double CalculateResult()
        {
           return this._calculator.CalculatedResult();
        }

        public void AddValue(double value)
        {
            if (this._firtValue)
            {
                this._firtValue = false;
                this._calculator.Add(value);
            }
            else
            {

            }
        }
        public void AddOperation(OperationBase op)
        {
            this._calculator.Add(op);
        }
    }
}
