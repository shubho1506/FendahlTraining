using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delegates
{

    //A delegate in C# is a type that represents references to methods with a specific signature.
    //It is similar to a function pointer in C or C++, but it is type-safe and object-oriented.

    //Key Features of Delegates:
    //Type Safety – Delegates ensure that the method signature matches the delegate signature.
    //Encapsulation of Methods – A delegate can reference methods dynamically at runtime.
    //Multicast Delegates – Delegates can hold references to multiple methods.
    //Used in Callbacks & Events – Delegates are the foundation for events and callbacks in C#.
    //Flexibility – Enables passing methods as arguments to other methods.

    // Defining a delegate type
    public delegate void MyDelegate(string message);

    // Step 1 - Defining a delegate type
    public delegate void Callback(string message);

    //Multicast delegates
    public delegate void MyCommonDelegate(string message);

    //Anonymous delegate
    public delegate void MyAnonDelegate(string message);

    //Lambda expressions with delegates 
    public delegate int Operation(int a, int b);


    class Program
    {
        // Method that matches the delegate signature
        public static void DisplayMessage(string msg)
        {
            Console.WriteLine("Message: " + msg);
        }

        //Step 2 - Define a method that accept delegate as a parameter
        public static void ProcessedData(string data, Callback callback)
        {
            string result = $"processed : {data}";
            callback(result);
        }

        // Step 3 - Method that matches the delegate signature
        public static void ShowResult(string message)
        {
            Console.WriteLine(message);
        }

        public static void Method1(string msg)
        {
            Console.WriteLine("Method1: " + msg);
        }

        public static void Method2(string msg)
        {
            Console.WriteLine("Method2: " + msg);
        }

        static void Main(string[] args)
        {
            // Creating an instance of the delegate and assigning a method
            //MyDelegate del = new MyDelegate(DisplayMessage);

            // Invoking the delegate
            //del("Hello, Delegates!");

            //ProcessedData("hello",ShowResult);

            //MyCommonDelegate del1 = Method1;
            //MyCommonDelegate del2 = Method2;

            //// Combining delegates
            //MyCommonDelegate delCombined = del1 + del2;

            //// Invoking multicast delegate
            //delCombined("Hello!");


            //MyAnonDelegate dele = delegate (string msg)
            //{
            //    Console.WriteLine("Anonymous method says: " + msg);
            //};

            //dele("Hello, world!");

            //Operation add = (x, y) => x + y;
            //Console.WriteLine(add(10, 5));

            CalculatorImplementation();

        }

        static void CalculatorImplementation()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(5, 6));
            Console.WriteLine(calculator.Subtract(15, 6));
            Console.WriteLine(calculator.Multiply(5, 6));
            Console.WriteLine(calculator.Divide(36, 6));
        }
    }
}
