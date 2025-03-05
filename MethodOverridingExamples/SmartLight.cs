using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class SmartLight : SmartDevice
    {
        public override void TurnOn(int duration)
        {
            Console.WriteLine($"Turning on SmartLight for {duration} minutes...");
        }
    }
}
