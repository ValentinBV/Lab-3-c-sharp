using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labs_3;
using System;

namespace UnitTestLabs3
{
    [TestClass]
    public class PassengerCarTest
    {
        private PassengerCar car;

        [TestInitialize]
        public void TestInitialize()
        {
            car = new PassengerCar(CarsType.Sedan);
        }
        [TestMethod]
        public void TestConstructorOK()
        {
            Assert.IsTrue(car.CarsType.GetType() == typeof(CarsType));
        }
        [TestMethod]
        public void TestSetWeightArgumentOutOfRangeException()
        {
            try
            {
                car.Weight = 0;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Value must be more than zero");
            }
        }
        [TestMethod]
        public void TestSetCorrectWeight()
        {
            float weight = 1200;
            car.Weight = weight;
            Assert.AreEqual(car.Weight, weight);
        }
        [TestMethod]
        public void TestSetYearArgumentOutOfRangeException()
        {
            try
            {
                car.Year = 0;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Value must be more than zero");
            }
        }
        [TestMethod]
        public void TestSetCorrectYear()
        {
            int year = 2000;
            car.Year = year;
            Assert.AreEqual(car.Year, year);
        }
        [TestMethod]
        public void TestCarsTypeOK()
        {
            Assert.IsTrue(car.CarsType.GetType() == typeof(CarsType));
        }
    }
}
