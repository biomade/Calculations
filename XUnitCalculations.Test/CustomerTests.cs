using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitCalculations.Test
{
    public class CustomerTests
    {
        [Fact]
        public void Age_CorrectRange()
        {
            var cust = new Customer();
            Assert.InRange(cust.Age, 25, 40);
        }

        [Fact]
        public void Name_CheckNotEmpty()
        {
            var cust = new Customer();
            Assert.NotNull(cust.Name);
            Assert.False(string.IsNullOrEmpty(cust.Name));
        }
    }
}
