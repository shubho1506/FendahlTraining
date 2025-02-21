using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class Circle : IShape
    {
        public string Name { get; }
        public double Radius { get; }

        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"The area of {Name} is {CalculateArea():F2} square units.");
        }
    }
}
