using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calculation
    {
        public List<int> FiboNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13 };

        public bool isOdd(int value)
        {
            return (value % 2) == 1;
        }


    }
}
