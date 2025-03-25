using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace JSON_XMLManipulation
{
    // Product class with properties
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class JSONManipulation
    {
        public static void Start()
        {
            // Create an object
            Product product = new Product
            {
                Id = 101,
                Name = "Laptop",
                Price = 75000.50
            };

            // Serialize Object to JSON
            string jsonData = JsonConvert.SerializeObject(product, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine("Serialized JSON:\n" + jsonData);

            // Write JSON to a file
            File.WriteAllText("product.json", jsonData);
            Console.WriteLine("\nJSON written to file successfully.");

            // Read JSON from the file
            string jsonFromFile = File.ReadAllText("product.json");
            Console.WriteLine("\nJSON read from file:\n" + jsonFromFile);

            // Deserialize JSON to Object
            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(jsonFromFile);
            Console.WriteLine("\nDeserialized Object:");
            Console.WriteLine($"ID: {deserializedProduct.Id}, Name: {deserializedProduct.Name}, Price: {deserializedProduct.Price}");
        }
    }
}
