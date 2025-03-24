using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsInCSharp
{
    static class NewClass
    {
        public static void test3(this OldClass o)
        {
            Console.WriteLine($"Method 3 {o.x}");
        }

        public static void test4(this OldClass o,int z)
        {
            Console.WriteLine($"Method 4 {o.x} {z}");
        }

        public static void test5(this OldClass o)
        {
            Console.WriteLine($"Method 5 {o.x * 10}");
        }
    }
}
