using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTestUnitTest
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void IsSqrtTest()
        {
            double input = 4;
            int expected = 2;

            double actual = Math.Sqrt(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BandingkanStringSama()
        {
            string input = "hello";
            string expected = "hello";

            Assert.AreSame(expected, input);
        }
    }
}
