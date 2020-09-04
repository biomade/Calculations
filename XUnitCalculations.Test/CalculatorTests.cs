using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitCalculations.Test
{
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

        [Fact]
        public void FiboNumbers_DoesNotIncludeZero()
        {
            var calc = new Calculator();
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_Includes13()
        {
            var calc = new Calculator();
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_DoesNotInclude4()
        {
            var calc = new Calculator();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_ExactCollection()
        {
            var calc = new Calculator();
            var lstExpected = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

            Assert.Equal(lstExpected, calc.FiboNumbers);
        }
    }
}
