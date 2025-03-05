using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class SmartDevice
    {
        //1. Smart Home Device Control System
        //Scenario: You are designing a smart home system where different devices(Lights, AC, TV) have different behaviors when turned on.
        //•	Create a base class SmartDevice with a method TurnOn().
        //•	Override TurnOn() in derived classes(SmartLight, SmartAC, SmartTV).
        //•	Implement a method TurnOn(int duration) in each class to keep the device on for a specific time.

        public virtual void TurnOn(int duration)
        {
            Console.WriteLine("Turning on...");
        }
    }
}
