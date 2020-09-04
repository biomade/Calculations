using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XUnitCalculations.Test
{
    public class CalculatorFixture:IDisposable
    {
        public Calculator Calc => new Calculator();

        public void Dispose()
        {
            //clean up 
        }
    }

    public class CalculatorTests
    {
               
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsIntSum()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDblValues_ReturnsDblSum()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.2, 2.3);
            Assert.Equal(3.5, result);
            
            ////with precision
            //result = calc.AddDouble(1.23, 2.34);
            //Assert.Equal(3.57, result, 1); //rounds up
        }


    }

}
