using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    //5. Problem 5: Shape Area Calculation
    //    Problem Statement:
    //Design a structure to model shapes and calculate their areas.Include common functionality for shapes,
    //and implement specific calculations for different types of shapes, such as Rectangle and Circle.
    //Ensure that all shapes can be processed in a uniform way.
    //    Objective:
    //Demonstrate dynamic behavior across different types of shapes while maintaining a common interface for calculation.
    interface IShape
    {
        double CalculateArea();
        void DisplayArea();
    }
}
