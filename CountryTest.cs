using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labs_3;
using System;

namespace UnitTestLabs3
{
    [TestClass]
    public class CountryTest
    {
        [TestMethod]
        public void TestConstruct_OK()
        {
            Country country = new Country("RU", "Russia");
            Assert.AreEqual("RU", country.Code);
            Assert.AreEqual("Russia", country.Name);
        }
        [TestMethod]
        public void TestCodeArgumentOutOfRangeException()
        {
            try
            {
                Country country = new Country("RURU", "Russia");
                Assert.Fail();
            } 
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Value must be more than 1 and small than 3");
            }
        }
        [TestMethod]
        public void TestNameArgumentOutOfRangeException()
        {
            try
            {
                Country country = new Country("RU", "This is a very long country name that is not correct.");
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Value must be more than 1 and small than 20");
            }
        }
    }
}
