using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace SerializationInCSharp
{
    class Program
    {
        //Serialization is the process of converting an object into a byte stream so
        //that it can be stored in a file, sent over a network, or saved in a database.
        //The byte stream can then be deserialized back into the original object.

        //Why Use Serialization?
        //Serialization is useful when:
        //✅ Saving application state to a file.
        //✅ Transmitting data between systems (e.g., APIs, network communication).
        //✅ Caching objects for performance improvement.
        //✅ Storing complex data structures in databases.

        //C# supports multiple types of serialization :

        //Binary Serialization - Converts objects into a binary format (obsolete in .NET 5+).
        //XML Serialization - Converts objects into XML format.
        //JSON Serialization - Converts objects into JSON format(widely used in web APIs).
        //Custom Serialization - Implements manual control over object serialization.
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== XML Serialization Example ===");
            XmlSerializationExample xmlExample = new XmlSerializationExample();
            xmlExample.Serialize();
            xmlExample.Deserialize();

            Console.WriteLine("\n=== JSON Serialization Example ===");
            JsonSerializationExample jsonExample = new JsonSerializationExample();
            jsonExample.Serialize();
            jsonExample.Deserialize();

            Console.WriteLine("\n=== Custom Serialization Example ===");
            CustomSerializationExample example = new CustomSerializationExample();
            example.Serialize();
            example.Deserialize();
        }
    }
}
