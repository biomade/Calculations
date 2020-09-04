using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitCalculations.Test
{
    [CollectionDefinition("Customer")]
    public class CustomerFixtureCollection:ICollectionFixture<CustomerFixture>
    {
        //marker interface so nothing else required.
    }
}
