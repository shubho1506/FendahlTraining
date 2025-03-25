using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JSON_XMLManipulation
{
    class XMLManipulation
    {
        public static void CreateXml()
        {
            XDocument doc = new XDocument(
                new XElement("Products",
                    new XElement("Product",
                        new XAttribute("ID", 1),
                        new XElement("Name", "Laptop"),
                        new XElement("Price", "80000")
                    ),
                    new XElement("Product",
                        new XAttribute("ID", 2),
                        new XElement("Name", "Smartphone"),
                        new XElement("Price", "50000")
                    )
                )
            );

            doc.Save("Products.xml");
            Console.WriteLine("XML File Created Successfully!");
        }

        //<Products>
        //  <Product ID = "1" >
        //    < Name > Laptop </ Name >
        //    < Price > 80000 </ Price >
        //  </ Product >
        //  < Product ID="2">
        //    <Name>Smartphone</Name>
        //    <Price>50000</Price>
        //  </Product>
        //</Products>


        public static void ReadXml()
        {
            XDocument doc = XDocument.Load("Products.xml");
            foreach (XElement product in doc.Descendants("Product"))
            {
                Console.WriteLine($"ID: {product.Attribute("ID")?.Value}");
                Console.WriteLine($"Name: {product.Element("Name")?.Value}");
                Console.WriteLine($"Price: {product.Element("Price")?.Value}\n");
            }
        }

        public static void ModifyXml()
        {
            XDocument doc = XDocument.Load("Products.xml");

            XElement product = doc.Descendants("Product")
                                  .FirstOrDefault(p => (string)p.Attribute("ID") == "2");

            if (product != null)
            {
                product.Element("Price")?.SetValue("45000"); // Modify price
                doc.Save("Products.xml");
                Console.WriteLine("XML Modified Successfully!");
            }
        }

    }
}
