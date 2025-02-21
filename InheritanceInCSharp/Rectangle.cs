using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class Rectangle : IShape
    {
        public string Name { get; }
        public double Width { get; }
        public double Height { get; }

        public Rectangle(string name, double width, double height)
        {
            Name = name;
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"The area of {Name} is {CalculateArea():F2} square units.");
        }
    }
}
