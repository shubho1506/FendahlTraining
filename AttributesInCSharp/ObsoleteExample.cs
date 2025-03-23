using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    // 1. Obsolete Attribute Example
    class ObsoleteExample
    {
        [Obsolete("Use NewMethod instead")]
        public void OldMethod()
        {
            Console.WriteLine("This method is obsolete.");
        }

        public void NewMethod()
        {
            Console.WriteLine("New method.");
        }
    }
}
