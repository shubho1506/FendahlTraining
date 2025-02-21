using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🟢 Creating Original Object
            Person original = new Person("Alice", new Address("New York"));

            // 🔴 Creating a Shallow Copy
            Person shallowCopy = original.ShallowCopy();

            // 🔵 Creating a Deep Copy using DeepCopy Method
            Person deepCopy1 = original.DeepCopy();

            // 🔵 Creating a Deep Copy using Copy Constructor
            Person deepCopy2 = new Person(original);

            // 🟢 Modifying Original Object's Address
            original.Address.City = "Los Angeles";

            // 🟢 Printing Values to See the Differences
            Console.WriteLine("Original Address: " + original.Address.City);   // Los Angeles
            Console.WriteLine("Shallow Copy Address: " + shallowCopy.Address.City); // Los Angeles ❌ (Same reference)
            Console.WriteLine("Deep Copy 1 Address: " + deepCopy1.Address.City); // New York ✅ (Independent)
            Console.WriteLine("Deep Copy 2 Address: " + deepCopy2.Address.City); // New York ✅ (Independent)
        }
    }
}
