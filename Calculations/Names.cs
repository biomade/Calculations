using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Names
    {
        public string MakeFullName(string first, string last)
        {
            return $"{first} {last}";
        }

        public string NickName { get; set; }
    }
}
