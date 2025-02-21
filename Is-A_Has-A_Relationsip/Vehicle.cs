using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    //1. Problem:
    //Design a basic transportation management system for a vehicle rental company.
    //The system should include different types of vehicles such as Cars, Motorbikes, and Bicycles.
    //All these vehicles share common properties like LicensePlate, MaxSpeed, and StartEngine().
    //Each vehicle type also has its specific behaviors.
    //Solution Hint:
    //•	Create a Vehicle base class with common properties and methods.
    //•	Derive specific classes (Car, Motorbike, Bicycle) from the base class.
    class Vehicle
    {
        public string LicensePlate { get; set; }
        public int MaxSpeed { get; set; }

        public Vehicle(string licensePlate, int maxSpeed)
        {
            LicensePlate = licensePlate;
            MaxSpeed = maxSpeed;
        }
        public virtual void StartEngine()
        {
            Console.WriteLine($"Starting engine of vehicle with License Plate: {LicensePlate}");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"License Plate: {LicensePlate}, Max Speed: {MaxSpeed} km/h");
        }
    }
}
