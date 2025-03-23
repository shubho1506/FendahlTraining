using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    // 4. Applying Custom Attribute
    [Author("Shubhodeep", Version = 1.1)]
    class CustomAttributeExample
    {
        public void Display() => Console.WriteLine("This method is part of CustomAttributeExample class.");
    }
}
