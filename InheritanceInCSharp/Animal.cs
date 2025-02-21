using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    //3. Problem 3: Animal Sounds
    //Problem Statement:
    //Develop a class structure to represent animals.Implement common functionality like Speak and allow different animal types,
    //such as Dog and Cat, to add their unique behaviors.
    //Objective:
    //Illustrate how multiple related entities can share a common behavior but have their own specialized actions.
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
}
