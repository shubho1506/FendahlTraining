using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    class InterfaceSegregationPrinciple
    {
        public interface IWorkable
        {
            void Work();
        }

        public interface IEatable
        {
            void Eat();
        }

        public class Human : IWorkable, IEatable
        {
            public void Work() => Console.WriteLine("Human working");
            public void Eat() => Console.WriteLine("Human eating");
        }

        public class Robot : IWorkable
        {
            public void Work() => Console.WriteLine("Robot working");
        }

    }
}
