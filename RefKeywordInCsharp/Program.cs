using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeywordInCsharp
{
    internal class Program
    {
        static void Increment(int num)
        {
            num++;
        }

        static void Increment(ref int num)
        {
            num++;
        }

        class Person { public string Name; }

        static void ChangeName(Person p)
        {
            p.Name = "Shubhodeep";
        }

        static void Reassign(Person p)
        {
            p = new Person { Name = "Rahul" };
        }

        static void Reassign(ref Person p)
        {
            p = new Person { Name = "Rahul" };
        }

        static void Main(string[] args)
        {
            int a = 5;
            Increment(a);
            Console.WriteLine(a);  // Output: 5 — no change

            Increment(ref a);
            Console.WriteLine(a);  // Output: 6 — changed!

            Person person = new Person { Name = "Unknown" };
            ChangeName(person);
            Console.WriteLine(person.Name);  // Output: Shubhodeep ✅

            // Reassigning the reference
            Person person1 = new Person { Name = "Shubhodeep" };
            Reassign(person1);
            Console.WriteLine(person1.Name);  // Output: Shubhodeep ❌ not Rahul

            Person person2 = new Person { Name = "Shubhodeep" };
            Reassign(ref person2);
            Console.WriteLine(person2.Name);  // Output: Rahul ✅
        }
    }
}
