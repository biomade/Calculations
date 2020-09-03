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

        //[Fact]
        //public void Name_CheckNotEmpty()
        //{
        //    var cust = new Customer();
        //    Assert.NotNull(cust.Name);
        //    Assert.False(string.IsNullOrEmpty(cust.Name));
        //}

        [Fact]
        public void GetOrdersByName_NotNull()
        {
            var cust = new Customer();
            //this will result in the test failing because the name is NOT null
            Assert.Throws<ArgumentException>(() => cust.GetOrdersByName("laurie"));
            var result = cust.GetOrdersByName("laurie"); 
            Assert.Equal(100, result);
        }

        [Fact]
        public void GetOrdersByName_ThrowsExceptionWhenNameIsNull()
        {
            var cust = new Customer();
            var exceptDetails = Assert.Throws<ArgumentException>(() => cust.GetOrdersByName(null));
            Assert.Equal("An exception has been thrown!", exceptDetails.Message);
        }

    }
}
