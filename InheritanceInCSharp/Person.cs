using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    //1. Problem 1: Person and Student Application
    //Problem Statement:
    //Create a class structure to represent Person and Student entities.
    //The Person should have properties like Name and Age, and there should be a way for
    //the Student to display their full information, including their Grade.
    //Objective:
    //Demonstrate the relationship between a general entity and a more specialized entity.
    class Person
    {
        internal string Name { get; set; }
        internal int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
