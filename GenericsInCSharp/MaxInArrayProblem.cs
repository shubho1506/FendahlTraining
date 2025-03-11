using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    //Problem 3: Find Maximum in an Array
    //Write a generic method FindMax<T> that takes an array of elements and returns the maximum value.
    //The type T should implement IComparable<T>
    class MaxInArrayProblem
    {
        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            T max = array[0];
            foreach (T item in array)
                if (item.CompareTo(max) > 0) max = item;
            return max;
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Find Maximum in an Array ---");
            Console.Write("Enter space-separated numbers: ");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine($"Maximum Value: {FindMax(numbers)}");
        }
    }
}
