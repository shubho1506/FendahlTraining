using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AttributesInCSharp
{
    // 6. JSON Serialization Example (JsonProperty)
    class JsonSerializationExample
    {
        public class Product
        {
            [JsonProperty("product_name")]
            public string Name { get; set; }
        }

        public void SerializeProduct()
        {
            Product p = new Product { Name = "Laptop" };
            string json = JsonConvert.SerializeObject(p);
            Console.WriteLine($"Serialized JSON: {json}");
        }
    }
}
