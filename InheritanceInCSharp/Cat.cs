using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} meows: Meow! Meow!");
        }
    }
}
