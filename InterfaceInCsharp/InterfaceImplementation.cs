using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCsharp
{
    class InterfaceImplementation : IClassHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello !!!");
        }

        void IClassHello.ExplicitHello()
        {
            Console.WriteLine("Explict Say Hello");
        }
    }
}
