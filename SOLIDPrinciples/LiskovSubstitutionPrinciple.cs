using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    class LiskovSubstitutionPrinciple
    {
        public abstract class Bird
        {
            public abstract void Move();
        }

        public class FlyingBird : Bird
        {
            public override void Move()
            {
                Console.WriteLine("Bird is flying");
            }
        }

        public class Penguin : Bird
        {
            public override void Move()
            {
                Console.WriteLine("Penguin is swimming");
            }
        }

    }
}
