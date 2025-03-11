using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    //Problem 6: Count Occurrences in a List
    //Create a generic method CountOccurrences<T> that counts how many times a specific element appears in a list.
    class CountOccurenceProblem
    {
        public static int CountOccurrences<T>(List<T> list, T value)
        {
            return list.Count(item => item.Equals(value));
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Count Occurrences in a List ---");
            Console.Write("Enter space-separated values: ");
            List<string> list = Console.ReadLine().Split().ToList();

            Console.Write("Enter value to count: ");
            string value = Console.ReadLine();

            Console.WriteLine($"Occurrences of '{value}': {CountOccurrences(list, value)}");
        }
    }
}
