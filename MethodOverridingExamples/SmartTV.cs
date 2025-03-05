using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class SmartTV : SmartDevice
    {
        public override void TurnOn(int duration)
        {
            Console.WriteLine($"Turning on SmartTV for {duration} minutes...");
        }
    }
}
