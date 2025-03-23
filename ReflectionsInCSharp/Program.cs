using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReflectionsInCSharp
{
    //Reflection in C# allows us to inspect, invoke, and manipulate types
    //(classes, methods, properties, fields, assemblies, etc.) at runtime.

    //Why Use Reflection?
    //Dynamically load and inspect assemblies.
    //Instantiate objects and invoke methods at runtime.
    //Access private members(for debugging or testing).
    //Retrieve metadata(attributes, method signatures, etc.).
    class Sample1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("Hello from Display Method!");
        }
    }
    class Sample2
    {
        public void Greet(string message)
        {
            Console.WriteLine("Message: " + message);
        }
    }
    class Sample3
    {
        public string Name { get; set; }

        public void Show()
        {
            Console.WriteLine("Hello, " + Name);
        }
    }
    class Sample4
    {
        private string secret = "Hidden Data";
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class MyAttribute : Attribute
    {
        public string Description { get; }
        public MyAttribute(string desc) => Description = desc;
    }

    [MyAttribute("This is a sample class")]
    class Sample5
    {
        [MyAttribute("This is a sample method")]
        public void Display() { }
    }

    class Program
    {
        static void Main()
        {
            //RetrievingTypeInformation();
            //InvokingMethodsDynamically();
            //CreatingInstancesDynamically();
            //AccessingPrivateMembers();
            //ReadingAttributes();
            InspectingAssemblies();
        }

        //1. Retrieving Type Information
        //We can use reflection to get details about a class, its methods, properties, and fields.
        static void RetrievingTypeInformation()
        {
            Type type = typeof(Sample1);

            Console.WriteLine("Class Name: " + type.Name);
            Console.WriteLine("\nProperties:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine(prop.Name);
            }

            Console.WriteLine("\nMethods:");
            foreach (var method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
        }

        //2. Invoking Methods Dynamically
        //Reflection allows calling methods at runtime, even if we don't know their names at compile time.
        static void InvokingMethodsDynamically()
        {
            Type type = typeof(Sample2);
            object obj = Activator.CreateInstance(type); // Create instance dynamically

            MethodInfo method = type.GetMethod("Greet");
            method.Invoke(obj, new object[] { "Hello from Reflection!" });
        }

        //3. Creating Instances Dynamically
        //Reflection lets us create objects of a class at runtime, even if we don’t know the class name in advance.
        static void CreatingInstancesDynamically()
        {
            Type type = typeof(Sample3);
            object obj = Activator.CreateInstance(type); // Create an instance

            PropertyInfo prop = type.GetProperty("Name");
            prop.SetValue(obj, "Shubhodeep");

            MethodInfo method = type.GetMethod("Show");
            method.Invoke(obj, null);
        }

        //4. Accessing Private Members
        //Reflection can access private fields and methods, which are normally hidden.
        static void AccessingPrivateMembers()
        {
            Type type = typeof(Sample4);
            object obj = Activator.CreateInstance(type);

            FieldInfo field = type.GetField("secret", BindingFlags.NonPublic | BindingFlags.Instance);
            string value = (string)field.GetValue(obj);

            Console.WriteLine("Secret Value: " + value);
        }

        //5. Reading Attributes(Metadata Retrieval)
        //Attributes store metadata about classes, methods, and properties.
        //Reflection helps us fetch these attributes at runtime.
        static void ReadingAttributes()
        {
            Type type = typeof(Sample5);
            MyAttribute classAttr = (MyAttribute)Attribute.GetCustomAttribute(type, typeof(MyAttribute));
            Console.WriteLine("Class Attribute: " + classAttr.Description);

            MethodInfo method = type.GetMethod("Display");
            MyAttribute methodAttr = (MyAttribute)Attribute.GetCustomAttribute(method, typeof(MyAttribute));
            Console.WriteLine("Method Attribute: " + methodAttr.Description);
        }

        //6. Inspecting Assemblies
        //Assemblies contain compiled code(DLLs & EXEs). We can load assemblies dynamically and inspect their types.
        static void InspectingAssemblies()
        {
            // Get the assembly containing JsonSerializer
            Assembly assembly = typeof(JsonSerializer).Assembly;

            Console.WriteLine("Assembly: " + assembly.FullName);

            // List all types in the assembly
            foreach (Type type in assembly.GetTypes())
            {
                Console.WriteLine("Type: " + type.FullName);
            }
        }

        //✔ 🔹 Dynamic Plugin Loading – Apps like Visual Studio, ReSharper load extensions using Reflection.
        //✔ 🔹 Object-Relational Mappers(ORMs) – Entity Framework, Dapper use Reflection to map database models dynamically.
        //✔ 🔹 Dependency Injection(DI) Containers – ASP.NET Core uses Reflection to inject dependencies at runtime.
        //✔ 🔹 Unit Testing Frameworks – NUnit, xUnit use Reflection to detect test methods dynamically.
        //✔ 🔹 Serialization & Deserialization – JSON, XML serializers inspect object structures via Reflection.
    }
}
