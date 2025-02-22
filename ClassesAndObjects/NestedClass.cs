using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class NestedClass
    {
        internal class Nested
        {
            public void SayNested()
            {
                Console.WriteLine("This is Nested class. ");
            }
        }
    }
}
