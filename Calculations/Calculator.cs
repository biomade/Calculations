using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calculator
    {
        public int Add (int a, int b)
        {
            return a + b;
        }

        public double AddDouble(double a, double b)
        {
            return a + b;
        }

        public List<int> FiboNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13 };
    }
}
