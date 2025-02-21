using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    //2. Problem 2: Vehicle Hierarchy
    //Problem Statement:
    //Design a class structure to model different types of vehicles.
    //There should be a way for each type to share basic vehicle functionality (e.g., StartEngine) and then add specific features
    //for different vehicle types like Car and more advanced models like ElectricCar.
    //Objective:
    //Showcase how different vehicle types can build upon each other's functionality.
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public virtual void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started. Ready to go!");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
}
