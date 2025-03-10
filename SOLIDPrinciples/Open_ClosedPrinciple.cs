using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    //open for extension and closed for modification
    class Open_ClosedPrinciple
    {
        public interface IShape
        {
            double CalculateArea();
        }

        public class Circle : IShape
        {
            public double Radius { get; set; }
            public double CalculateArea() => Math.PI * Radius * Radius;
        }

        public class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public double CalculateArea() => Width * Height;
        }

        public class AreaCalculator
        {
            public double CalculateArea(IShape shape) => shape.CalculateArea();
        }
    }
}
