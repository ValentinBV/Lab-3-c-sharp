using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labs_3;
using System;

namespace UnitTestLabs3
{
    [TestClass]
    public class ServiceTest
    {
        private Service service;
        
        [TestMethod]
        public void TestConstructor()
        {
            service = new Service("Staff", "Client");
        }
        [TestMethod]
        public void TestAddCar()
        {
            int countAfterAdd = 1;
            service = new Service("Staff", "Client");
            Car car = new PassengerCar(CarsType.Sedan);
            service.AddCar(car);
            Assert.AreEqual(countAfterAdd, service.GetCarsCollection().Count);
        }
        [TestMethod]
        public void TestRemoveCarCorrect()
        {
            int elementId = 0;
            int countAfterRemove = 0;
            service = new Service("Staff", "Client");
            Car car = new PassengerCar(CarsType.Sedan);
            service.AddCar(car);
            service.RemoveCar(elementId);
            Assert.AreEqual(countAfterRemove, service.GetCarsCollection().Count);
        }
        [TestMethod]
        public void TestRemoveCarInCorrect()
        {
            int elementId = 1;
            service = new Service("Staff", "Client");
            Car car = new PassengerCar(CarsType.Sedan);
            service.AddCar(car);
            try
            {
                service.RemoveCar(elementId);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is ArgumentOutOfRangeException);
            }
        }
    }
}
