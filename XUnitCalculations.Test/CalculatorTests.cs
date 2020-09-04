using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

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

    public interface ICalculatorFixture<T>
    {
    }

    public class CalculatorTests: ICalculatorFixture<CalculatorFixture>
    {
        //constructor with DI for text fixture
        private CalculatorFixture _calculatorFixture;
       public CalculatorTests(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }
       
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
        [Trait("Category", "Fibo")]
        public void FiboNumbers_DoesNotIncludeZero()
        {
            var calc = _calculatorFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_Includes13()
        {
            var calc = _calculatorFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_DoesNotInclude4()
        {
            var calc = _calculatorFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_ExactCollection()
        {
            var calc = _calculatorFixture.Calc;
            var lstExpected = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

            Assert.Equal(lstExpected, calc.FiboNumbers);
        }
    }

}
