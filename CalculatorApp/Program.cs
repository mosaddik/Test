﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculater =  new Calculator(5,4);
            calculater.Add();
            Console.ReadKey();

        }
    }
}
