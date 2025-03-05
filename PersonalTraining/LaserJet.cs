using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTraining
{
    class LaserJet : Printer
    {
        public sealed override void Display()
        {
            Console.WriteLine("Display unit 10x10");
        }
    }
}
