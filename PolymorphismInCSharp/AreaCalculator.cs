using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInCSharp
{
    //2. Problem Statement: Area Calculation for Shapes
    //Task: Create a Shape class with an overloaded CalculateArea method.
    //•	Requirement:
    //o One method should calculate the area of a circle given its radius (Area = π * r²).
    //o Another method should calculate the area of a rectangle given its length and width.
    //o A third method should calculate the area of a triangle given its base and height(Area = 0.5  base  height).
    //•	Objective: Show how the same method name can be reused for different shapes with varying parameters.

    class AreaCalculator
    {
        public double CalcArea(double radius)
        {
            return (3.14) * radius * radius;
        }

        public double CalcArea(double length,double breadth)
        {
            return length*breadth;
        }

        public double CalcArea(double basee ,double height,double Area = 0.5)
        {
            double area = (0.5) * basee * height;
            return area;
        }
    }
}
