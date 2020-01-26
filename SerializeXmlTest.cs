using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labs_3;
using System;
using System.IO;
using System.Xml.Serialization;

namespace UnitTestLabs3
{
    [TestClass]
    public class SerializeXmlTest
    {
        [TestMethod]
        public void TestSerializeServiceTree()
        {
            PassengerCar car = new PassengerCar(CarsType.Coupe);
            Service service = new Service("Staff", "Client");
            Country country = new Country("RU", "Russia");
            car.Country = country;
            service.AddCar(car);

            XmlSerializer formatter = new XmlSerializer(
                typeof(Service), 
                new Type[] { typeof(PassengerCar), typeof(Country) }
            );
            using (FileStream fs = new FileStream("tree.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, service);
            }
        }
        [TestMethod]
        public void TestDeserializationServiceTree()
        {
            XmlSerializer reader = new XmlSerializer(typeof(Service));
            StreamReader file = new StreamReader(@"tree.xml");
            Service overview = (Service)reader.Deserialize(file);
            file.Close();

            Console.WriteLine(overview.name);
        }
    }
}
