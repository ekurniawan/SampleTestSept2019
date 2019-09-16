using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleTestUnitTest
{
    [TestClass]
    public class CheckPassword
    {
        [TestMethod]
        public void CekApakahPasswordLebihBesar7()
        {
            //arrange
            string password = "Password@123";
            int expected = 5;

            //actual
            int hasil = SampleTest.DAL.MyHelperClass.GetPasswordStrength(password);

            Assert.AreEqual(expected, hasil);
        }
    }
}
