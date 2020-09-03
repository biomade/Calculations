using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitCalculations.Test
{
   public class NamesTests
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var name = new Calculations.Names();
            var result = name.MakeFullName("Laurie", "Kern");
            //Assert.Equal("Laurie Kern", result);

            ////to ignore case
            //Assert.Equal("Laurie Kern", result,ignoreCase:true);

            ////for partial
            //Assert.Contains("urie", result);

            ////starts with
            //Assert.StartsWith("Laur", result, StringComparison.InvariantCultureIgnoreCase);

            ////can also use regular expressions
            Assert.Matches("[A-Z]{1}[a-z]+[\\s][A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var name = new Calculations.Names();
            Assert.Null(name.NickName);
        }

        [Fact]
        public void NickName_MustBeNotNull()
        {
            var name = new Calculations.Names();
            name.NickName = "laur";
            Assert.NotNull(name.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var name = new Calculations.Names();
            var result = name.MakeFullName("Laurie", "Kern");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result)); //so it can't be empty
        }
    }
}
