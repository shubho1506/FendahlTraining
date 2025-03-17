using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsInCSharp
{
    //Problem 1: Temperature Monitor
    //Create a class TemperatureSensor that raises an event when the temperature exceeds a certain threshold.
    //•	Define a delegate TemperatureExceededHandler and an event TemperatureExceeded.
    //•	Create a method CheckTemperature(int temp) that raises the event if temp is greater than 40°C.
    //•	In the Main method, subscribe to this event and display a warning message when the event is triggered.

    public delegate void TemperatureExceededHandler(string warning);
    class TempretureSensor
    {
        public event TemperatureExceededHandler TemperatureExceeded;
        public void CheckTemperature(int temp)
        {
            Console.WriteLine($"Tempreture Reported : {temp}'c ");
            if (temp > 40)
                TemperatureExceeded?.Invoke("Tempreture exceeded !!! ");
        }
    }
}
