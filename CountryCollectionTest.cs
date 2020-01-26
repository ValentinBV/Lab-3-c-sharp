using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labs_3;
using System;

namespace UnitTestLabs3
{
    [TestClass]
    public class CountryCollectionTest
    {
        private Country country;
        private CountryCollection collection;

        [TestInitialize]
        public void TestInitialize()
        {
            country = new Country("RU", "Russia");
            collection = new CountryCollection();
        }
        [TestMethod]
        public void TestAdd()
        {
            int countAfterAdd = 1;
            collection.Add(country);
            Assert.AreEqual(countAfterAdd, collection.GetCollection().Count);
        }

        [TestMethod]
        public void TestRemoveCorrect()
        {
            int elementId = 0;
            int countAfterAdd = 1;
            int countAfterRemove = 0;
            collection.Add(country);
            Assert.AreEqual(countAfterAdd, collection.GetCollection().Count);
            collection.Remove(elementId);
            Assert.AreEqual(countAfterRemove, collection.GetCollection().Count);
        }
        [TestMethod]
        public void TestRemoveInCorrect()
        {
            int elementId = 1;
            collection.Add(country);
            try
            {
                collection.Remove(elementId);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is ArgumentOutOfRangeException);
            }            
        }

    }
}
