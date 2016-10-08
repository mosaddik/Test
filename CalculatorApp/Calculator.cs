using System;
using System.Collections.Generic;
    using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public string FristNumner { get; set; }
        public string SecondNumber { get; set; }


        public Calculator(string fristNumber , string secondNumber)
        {
            FristNumner = fristNumber;
            SecondNumber = SecondNumber;
        }


        public int Add()
        {
            return Convert.ToInt32(FristNumner+SecondNumber);
        }
    }
}
