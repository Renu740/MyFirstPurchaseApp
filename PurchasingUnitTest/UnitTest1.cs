using PurchasingLibrary;
using System;
using Xunit;

namespace PurchasingUnitTest
{
    public class PurchasingTest
    {
        [Fact]
        public void CheckTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void PriceNeedToBePositive()
        {
            var customer = new CustomerDetails("Renu", "Baroda");

            // Test for negative price
            try
            {
                Assert.Throws<InvalidOperationException>(() => customer.PurchaseItem("Fridge", -45));

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught for negative price");
                Console.WriteLine(e.ToString());
            }

        }
        
    }
}
