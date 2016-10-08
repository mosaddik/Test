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
        public int FristNumner { get; set; }
        public int SecondNumber { get; set; }


        public Calculator(int fristNumber , int secondNumber)
        {
            FristNumner = fristNumber;
            SecondNumber = SecondNumber;
        }


        public int Add()
        {
            return Convert.ToInt32(FristNumner+SecondNumber);
        }
        public int Sub()
        {
            return Convert.ToInt32(FristNumner - SecondNumber);
        }

        public int MultiPlication()
        {
            return FristNumner*SecondNumber;
        }
    }
}
