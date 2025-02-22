using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ✅ 1️⃣ Lambda Function - Square of a number
            Func<int, int> square = x => x * x;
            Console.WriteLine($"Square of 5: {square(5)}");

            // ✅ 2️⃣ Lambda Function - Add two numbers
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Addition of 3 and 7: {add(3, 7)}");

            // ✅ 3️⃣ Lambda Function with Multiple Statements
            Func<int, int, int> multiply = (a, b) =>
            {
                int result = a * b;
                return result;
            };
            Console.WriteLine($"Multiplication of 4 and 5: {multiply(4, 5)}");

            // ✅ 4️⃣ Predicate - Check if a number is even
            Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine($"Is 8 even? {isEven(8)}");
            Console.WriteLine($"Is 7 even? {isEven(7)}");

            // ✅ 5️⃣ Predicate - Using FindAll to filter even numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = numbers.FindAll(isEven);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

            // ✅ 6️⃣ Predicate - Find names with more than 3 characters
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
            Predicate<string> longName = name => name.Length > 3;
            List<string> longNames = names.FindAll(longName);
            Console.WriteLine("Names longer than 3 characters: " + string.Join(", ", longNames));

        }
    }
}
