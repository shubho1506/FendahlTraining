using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    class GenericStackImplementation
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Generic Stack ---");
            GenericStackProblem<int> stack = new GenericStackProblem<int>();

            Console.Write("Enter numbers to push onto the stack (comma-separated): ");
            string[] input = Console.ReadLine().Split(',');
            foreach (string num in input)
            {
                stack.Push(int.Parse(num.Trim()));
            }

            Console.WriteLine($"Top of stack: {stack.Peek()}");
            Console.WriteLine($"Popped value: {stack.Pop()}");
            Console.WriteLine($"Is stack empty? {stack.IsEmpty()}");
        }
    }
}
