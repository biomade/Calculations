using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Customer
    {
       // public string Name => "Laurie";
        public int Age => 35;

        public int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name)){
                throw new ArgumentException("An exception has been thrown!");
            }
            return 100;
        }
    }
}
