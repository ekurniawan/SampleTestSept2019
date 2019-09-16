using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleTest.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTestUnitTest
{
    [TestClass]
    public class ShoppingCartAssemblyTest
    {
        public static ShoppingCart Cart { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Cart = new ShoppingCart();
            Cart.Add(new Item
            {
                ItemName = "Samsung S10",
                ItemQuantity = 5
            });
        }

        [TestMethod]
        public void CountAfterAddTest()
        {
            int expected = Cart.ItemCount + 1;

            Cart.Add(new Item
            {
                ItemName = "IPhone 11",
                ItemQuantity = 10
            });

            Assert.AreEqual(expected, Cart.ItemCount);
        }

        [TestMethod]
        public void AfterRemoveTest()
        {
            int expected = Cart.ItemCount - 1;
            Cart.Remove(0);

            Assert.AreEqual(expected, Cart.ItemCount);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanUp()
        {
            Cart.Dispose();
        }
    }
}
