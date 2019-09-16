using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleTest.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTestUnitTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        private ShoppingCart cart;
        private Item item;

        [TestInitialize]
        public void TestInitialize()
        {
            item = new Item
            {
                ItemName = "IPhone 11 Pro",
                ItemQuantity = 10
            };
            cart = new ShoppingCart();
            cart.Add(item);
        }

        [TestMethod]
        public void CheckoutTest()
        {
            CollectionAssert.Contains(cart.Items, item);
        }

        [TestMethod]
        public void RemoveItemTest()
        {
            int expected = 0;
            cart.Remove(0);
            Assert.AreEqual(expected, cart.ItemCount);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            cart.Dispose();
        }
    }
}
