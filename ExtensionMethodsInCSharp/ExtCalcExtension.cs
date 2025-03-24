using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsInCSharp
{
    static class ExtCalcExtension
    {
        public static int Multiply(this Calculator calc, int a, int b,int c)
        {
            return a * b * c;
        }
    }
}
