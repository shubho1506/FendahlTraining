using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    // 3. Custom Attribute Definition
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }
        public double Version { get; set; }

        public AuthorAttribute(string name)
        {
            Name = name;
            Version = 1.0; // Default version
        }
    }
}
