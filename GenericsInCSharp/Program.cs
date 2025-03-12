using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace GenericsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericClasses();
            //GenericMethods();
            //GenericConstraints();

            //Console.WriteLine("Practice Problems for Generics in C# ");

            //SwappingProblem.Run();

            //GenericStackImplementation.Run();

            //MaxInArrayProblem.Run();

            //KVPImplementation.Run();

            //ArraySortingProblem.Run();

            CountOccurenceProblem.Run();
        }

        // Generic Method with Type Parameter <T>
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Generics method
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }

        static void GenericClasses()
        {
            Storage<int> intStorage = new Storage<int>();  // Stores int
            intStorage.Store(100);
            Console.WriteLine(intStorage.Retrieve()); // Output: 100

            Storage<string> stringStorage = new Storage<string>(); // Stores string
            stringStorage.Store("Hello, Generics!");
            Console.WriteLine(stringStorage.Retrieve()); // Output: Hello, Generics!
        }

        static void GenericMethods()
        {
            int x = 10, y = 20;
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");

            string first = "Hello", second = "World";
            Console.WriteLine($"\nBefore Swap: first = {first}, second = {second}");
            Swap(ref first, ref second);
            Console.WriteLine($"After Swap: first = {first}, second = {second}");

            // creating object of class GFG
            Program p = new Program();

            // calling Generics method
            p.Display<int>("Integer", 122);
            p.Display<char>("Character", 'H');
            p.Display<double>("Decimal", 255.67);
        }


        //where T : class -  T must be a reference type - Repository<T> where T : class
        //where T : struct -  T must be a value type (int, double) - NumberProcessor<T> where T : struct
        //where T : new() - T must have a parameterless constructor - Factory<T> where T : new()
        //where T : BaseClass - T must inherit from BaseClass -   ChildClass<T> where T : ParentClass
        //where T : IComparable<T>    T must implement an interface - Sorter<T> where T : IComparable<T>

        static void GenericConstraints()
        {
            Repository<string> repo = new Repository<string>("sds"); // ✅ Allowed (string is a class)
            repo.Save("Generic Repository");

            // Repository<int> repo2 = new Repository<int>(); ❌ Error (int is not a class)
        }
    }
}
