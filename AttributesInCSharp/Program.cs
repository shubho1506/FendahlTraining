using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    class Program
    {
        //Attributes in C# provide metadata about your code (classes, methods, properties, etc.) and
        //allow additional information to be embedded within assemblies.
        //Attributes do not change the behavior of the code but can be used by compilers, runtime,
        //or reflection to modify execution or retrieve metadata.

        //Attributes help in:

        //Adding metadata(e.g., Obsolete, Serializable)

        //Controlling runtime behavior(e.g., DllImport for interop)

        //Providing hints for frameworks(e.g., JsonProperty in JSON serialization)

        //Code documentation & validation

        //Marking methods for testing(e.g., [TestMethod] in unit testing)
        static void Main(string[] args)
        {
            Console.WriteLine("=== Obsolete Attribute Example ===");
            var obsoleteExample = new ObsoleteExample();
            obsoleteExample.NewMethod();

            Console.WriteLine("\n=== DllImport Attribute Example ===");
            var dllExample = new DllImportExample();
            // Uncomment the next line if running on Windows
             dllExample.ShowMessageBox();

            Console.WriteLine("\n=== Custom Attribute & Reflection Example ===");
            var reflectionExample = new ReflectionExample();
            reflectionExample.RetrieveAttributes();

            Console.WriteLine("\n=== JSON Serialization Example ===");
            var jsonExample = new JsonSerializationExample();
            jsonExample.SerializeProduct();
        }
    }
}
