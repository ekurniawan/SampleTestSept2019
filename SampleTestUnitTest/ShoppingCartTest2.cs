using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleTest.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTestUnitTest
{
    [TestClass]
    public class ShoppingCartTest2
    {
        [TestMethod]
        public void TestCountAfterAdd2()
        {
            int expected = ShoppingCartAssemblyTest.Cart.ItemCount + 1;
            ShoppingCartAssemblyTest.Cart.Add(new Item
            {
                ItemName="IPhone 10",
                ItemQuantity=10
            });

            Assert.AreEqual(expected, ShoppingCartAssemblyTest.Cart.ItemCount);
        }
    }
}
