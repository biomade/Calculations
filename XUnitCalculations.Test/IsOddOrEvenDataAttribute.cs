using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace XUnitCalculations.Test
{
    public class IsOddOrEvenDataAttribute: DataAttribute
    {
        public override IEnumerable<object []> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 1, true };
            yield return new object[] { 2, false };
            //can also read data from an external file
        }
    }
}
