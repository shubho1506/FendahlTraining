using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    //Problem 5: Generic Method for Sorting an Array
    //Write a generic method SortArray<T> that sorts an array of any type (int, double, string).
    //The type T should implement IComparable<T>.
    class ArraySortingProblem
    {
        public static void UserInputAndSort<T>() where T : IComparable<T>
        {
            Console.Write("Enter the number of elements: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Invalid input! Enter a valid number: ");
            }

            T[] arr = new T[n];
            Console.WriteLine($"Enter {n} elements:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }

            Console.WriteLine("\nOriginal Array: " + string.Join(", ", arr));
            MergeSortArray(arr);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
        }

        public static void MergeSortArray<T>(T[] arr) where T : IComparable<T>
        {
            Divide(arr, 0, arr.Length - 1);
        }

        public static void Divide<T>(T[] arr, int si, int ei) where T : IComparable<T>
        {
            if (si >= ei) return;

            int mid = si + (ei - si) / 2;
            Divide(arr, si, mid);
            Divide(arr, mid + 1, ei);
            Conquer(arr, si, mid, ei);
        }

        public static void Conquer<T>(T[] arr, int si, int mid, int ei) where T : IComparable<T>
        {
            T[] merged = new T[ei - si + 1];
            int id1 = si, id2 = mid + 1, x = 0;

            while (id1 <= mid && id2 <= ei)
            {
                if (arr[id1].CompareTo(arr[id2]) < 0)
                    merged[x++] = arr[id1++];
                else
                    merged[x++] = arr[id2++];
            }

            while (id1 <= mid)
                merged[x++] = arr[id1++];

            while (id2 <= ei)
                merged[x++] = arr[id2++];

            for (int i = 0; i < merged.Length; i++)
                arr[si + i] = merged[i];
        }

        public static void Run()
        {
            Console.WriteLine("Choose data type for sorting: \n1. Integer \n2. Double \n3. String");
            Console.Write("Enter choice (1/2/3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    UserInputAndSort<int>();
                    break;
                case "2":
                    UserInputAndSort<double>();
                    break;
                case "3":
                    UserInputAndSort<string>();
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please restart the program.");
                    break;
            }
        }
    }
}
