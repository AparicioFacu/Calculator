using Business.Models;
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

        public CalculatorViewModel()
        {
            this._calculator = new CalculatorWithHistory();
        }

        public void CalculateResult()
        {
            this._calculator.CalculatedResult();
        }
    }
}
