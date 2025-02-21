using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    //4. Problem 4: Duck Behavior
    //Problem Statement:
    //Create a class structure to model a Duck that can exhibit behaviors like Fly and Swim.
    //These behaviors should be separated and combined in the Duck class. Implement a solution that demonstrates the duck's behavior.
    //Objective:
    //Show how different behaviors can be composed to represent a more complex entity.
    class Duck : IFlyable,ISwimmable
    {
        public string Name { get; set; }

        public Duck(string name)
        {
            Name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying high in the sky!");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming in the pond.");
        }

        public void ShowBehaviors()
        {
            Fly();
            Swim();
        }
    }
}
