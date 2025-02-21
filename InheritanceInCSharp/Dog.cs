﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceInCSharp
{
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine($"{Name} barks: Woof! Woof!");
        }
    }
}
