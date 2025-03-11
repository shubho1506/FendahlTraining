using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    //Problem 1: Swap Two Values
    //Create a generic method Swap<T> that takes two parameters by reference and swaps their values.
    //Test it with integers, doubles, and strings.
    class SwappingProblem
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Swap Two Values ---");
            Console.Write("Enter first value: ");
            string first = Console.ReadLine();
            Console.Write("Enter second value: ");
            string second = Console.ReadLine();

            Console.WriteLine($"Before Swap: First = {first}, Second = {second}");
            Swap(ref first, ref second);
            Console.WriteLine($"After Swap: First = {first}, Second = {second}");
        }
    }
}
