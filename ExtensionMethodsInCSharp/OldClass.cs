using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsInCSharp
{
    sealed class OldClass
    {
        public int x = 100;
        public void test1()
        {
            Console.WriteLine("Method 1");
        }

        public void test2()
        {
            Console.WriteLine($"Method 2 {x}");
        }
    }
}
