using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace OOP_Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car = new Car(5, 23, "Cruiser");

            // 1

            //Binary
            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\BinaryFormatter.txt", FileMode.OpenOrCreate))
            {
                binary.Serialize(stream, Car);
                Console.WriteLine("Binary serialization of Car is successful, check BinaryFormatter.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\BinaryFormatter.txt", FileMode.Open))
            {
                Car Car2 = (Car)binary.Deserialize(stream);
                Console.WriteLine("Binary deserialization of Car is successful");
                Car2.Info();
                Console.WriteLine();
            }

            //Soap
            SoapFormatter soap = new SoapFormatter();
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\SoapFormatter.txt", FileMode.OpenOrCreate))
            {
                soap.Serialize(stream, Car);
                Console.WriteLine("Soap serialization of Car is successful, check SoapFormatter.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\SoapFormatter.txt", FileMode.Open))
            {
                Car Car2 = (Car)soap.Deserialize(stream);
                Console.WriteLine("Soap deserialization of Car is successful");
                Car2.Info();
                Console.WriteLine();
            }

            //Xml
            XmlSerializer xml = new XmlSerializer(typeof(Car));
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\XmlSerializer.txt", FileMode.OpenOrCreate))
            {
                xml.Serialize(stream, Car);
                Console.WriteLine("Xml serialization of Car is successful, check XmlSerializer.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\XmlSerializer.txt", FileMode.Open))
            {
                Car Car2 = (Car)xml.Deserialize(stream);
                Console.WriteLine("Xml deserialization of Car is successful");
                Car2.Info();
                Console.WriteLine();
            }

            //Json
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Car));
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\JsonSerializer.txt", FileMode.OpenOrCreate))
            {
                json.WriteObject(stream, Car);
                Console.WriteLine("Json serialization of Car is successful, check JsonSerializer.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\JsonSerializer.txt", FileMode.Open))
            {
                Car Car2 = (Car)json.ReadObject(stream);
                Console.WriteLine("Json deserialization of Car is successful");
                Car2.Info();
                Console.WriteLine();
            }

            //2
            Car[] Cars = new Car[] {Car, new Car(2, 23, "Merc"), new Car(4, 23, "Audi")};
            XmlSerializer XmlArr = new XmlSerializer(typeof(Car[]));
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\MassXmlSerializer.txt", FileMode.OpenOrCreate))
            {
                XmlArr.Serialize(stream, Cars);
                Console.WriteLine("Xml serialization of XmlArr is successful, check MassXmlSerializer.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\MassXmlSerializer.txt", FileMode.Open))
            {
                Car[] Car2 = (Car[])XmlArr.Deserialize(stream);
                Console.WriteLine("Xml deserialization of XmlArr is successful");
                for (int i = 0; i < 3; i++)
                {
                    Car2[i].Info();
                }
                Console.WriteLine();
            }

            //3
            XPathDocument doc = new XPathDocument(@"D:\учеба\ООП\lab14\MassXmlSerializer.txt");
            XPathNavigator navigator = doc.CreateNavigator();
            XPathNodeIterator iter = navigator.Select("/ArrayOfCar/Car");
            Console.WriteLine("Cars count:" + navigator.Evaluate("count(/ArrayOfCar/Car)"));
            while (iter.MoveNext())
            {
                Console.WriteLine($"Car: {iter.Current.Value}");
            }
            Console.WriteLine();

            //4
            XDocument xdoc = new XDocument(new XElement("Countries",
                new XElement("country", new XAttribute("Name", "USA"),
                    new XElement("continent", "America"),
                    new XElement("square", "1000")),
                new XElement("country", new XAttribute("Name", "Belarus"),
                    new XElement("continent", "Europe"),
                    new XElement("square", "2000"))));
            xdoc.Save(@"D:\учеба\ООП\lab14\LinqXml.txt");

            XDocument xdoc2 = XDocument.Load(@"D:\учеба\ООП\lab14\LinqXml.txt");
            var linqXml = from x in xdoc2.Descendants("country")
                          where x.Element("square").Value == "2000"
                          select new
                          {
                              Name = x.Attribute("Name").Value,
                              Square = x.Element("square").Value
                          };
            foreach (var x in linqXml)
            {
                Console.WriteLine($"Country: {x.Name}, {x.Square}");
            }
        }
    }
}
