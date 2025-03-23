using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    // 5. Reflection Example (Retrieving Attributes)
    class ReflectionExample
    {
        public void RetrieveAttributes()
        {
            Type type = typeof(CustomAttributeExample);
            object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

            foreach (AuthorAttribute attr in attributes)
            {
                Console.WriteLine($"Author: {attr.Name}, Version: {attr.Version}");
            }
        }
    }
}
