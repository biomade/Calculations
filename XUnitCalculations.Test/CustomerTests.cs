﻿using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitCalculations.Test
{
    [Collection("Customer")] //for when you have more than one test class that will use the same fixture
    public class CustomerTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void Age_CorrectRange()
        {
            //var cust = new Customer();
            var cust = _customerFixture.Cust;
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

        [Fact]
        public void LoyalCustomer_ForOrdersGT100()
        {
            var cust = CustomerFactory.CreateCustomerInstance(102);
            var loyalCustom = Assert.IsType<LoyalCustomer>(cust);
            Assert.Equal(10, loyalCustom.Discount);
        }
    }
}
