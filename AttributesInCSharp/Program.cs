using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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


        //Commonly Used Attributes

        //[Obsolete] - Marks a method or class as deprecated.
        //[Serializable] - Indicates that a class can be serialized.
        //[DllImport] - Used for calling unmanaged code (P/Invoke).
        //[Conditional] - Allows execution based on compiler conditions.
        //[DebuggerStepThrough] - Skips method when debugging.
        //[Description] - Provides a text description for an element.

        //Common use of  Attributes
        //Logging and Auditing - Attributes help in tracking method calls, logging API requests, and maintaining audit trails.
        //Validation and Data Annotation - Enterprise applications often use DataAnnotations for input validation in ASP.NET Core MVC/Web APIs.
        //ORM Mapping(Entity Framework Core) - Attributes help map C# classes to database tables/columns in Entity Framework Core.
        //Security and Authorization- Attributes are widely used for role-based access control(RBAC) in ASP.NET Core.

        static void Main(string[] args)
        {
            //Console.WriteLine("=== Obsolete Attribute Example ===");
            //var obsoleteExample = new ObsoleteExample();
            //obsoleteExample.NewMethod();

            //Console.WriteLine("\n=== DllImport Attribute Example ===");
            //var dllExample = new DllImportExample();
            //// Uncomment the next line if running on Windows
            // dllExample.ShowMessageBox();

            //Console.WriteLine("\n=== Custom Attribute & Reflection Example ===");
            //var reflectionExample = new ReflectionExample();
            //reflectionExample.RetrieveAttributes();

            //Console.WriteLine("\n=== JSON Serialization Example ===");
            //var jsonExample = new JsonSerializationExample();
            //jsonExample.SerializeProduct();

            //Console.WriteLine();
            OrderService orderService = new OrderService();
            // Invoke using Logger
            Logger.ExecuteWithLogging(orderService, "ProcessOrder", 101);
        }
    }
}
