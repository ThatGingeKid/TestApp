using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Calculator
    {
        private double valueOne { get; set; }
        private double valueTwo { get; set; }

        public double AddTest(double valueOne, double valueTwo)
        {
            return valueOne + valueTwo;
        }
    }
}
