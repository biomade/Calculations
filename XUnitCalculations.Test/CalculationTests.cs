using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XUnitCalculations.Test
{
    public class CalculationFixture : IDisposable
    {
        public Calculation Calc => new Calculation();

        public void Dispose()
        {
            //clean up 
        }
    }

    public class CalculationTests : IClassFixture<CalculationFixture>
    {
        //constructor with DI for text fixture
        private readonly CalculationFixture _calculatorFixture;

        private readonly ITestOutputHelper _testOutputHelper;

        public CalculationTests(CalculationFixture calculationFixture, ITestOutputHelper testOutputHelper)
        {
            _calculatorFixture = calculationFixture;
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Contstructor");
        }


        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_DoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("FiboNumbers_DoesNotIncludeZero");
            var calc = _calculatorFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_Includes13()
        {
            _testOutputHelper.WriteLine("FiboNumbers_Includes13");
            var calc = _calculatorFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_DoesNotInclude4()
        {
            _testOutputHelper.WriteLine("FiboNumbers_DoesNotInclude4");
            var calc = _calculatorFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbers_ExactCollection()
        {
            _testOutputHelper.WriteLine("FiboNumbers_ExactCollection");
            var calc = _calculatorFixture.Calc;
            var lstExpected = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

            Assert.Equal(lstExpected, calc.FiboNumbers);
        }

        [Fact]
        public void IsOdd_GivenOddReturnsTrue()
        {
            var calc = new Calculation();
            var result = calc.isOdd(1);
            Assert.True(result);
        }

        [Fact]
        public void IsOdd_GivenEvenReturnsFalse()
        {
            var calc = new Calculation();
            var result = calc.isOdd(2);
            Assert.False(result);
        }

        [Theory]
        [InlineData(1,true)]
        [InlineData(2, false)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculation();
            var result = calc.isOdd(value);
            Assert.Equal(expected, result);
        }

        [Theory]
   
        [MemberData(memberName: nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEven_2(int value, bool expected)
        {
            var calc = new Calculation();
            var result = calc.isOdd(value);
            Assert.Equal(expected, result);
        }
    }
}
