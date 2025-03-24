using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(10, 20));
            Console.WriteLine(calculator.Subtract(10, 20));
            Console.WriteLine(calculator.Multiply(10, 20));
            Console.WriteLine(calculator.Multiply(10,5,5));


            OldClass oldClass = new OldClass();
            oldClass.test1();
            oldClass.test2();
            oldClass.test3();
            oldClass.test4(5);
            oldClass.test5();

        }
    }
}
