using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        public ElectricCar(string brand, int speed, int numberOfDoors, int batteryCapacity)
            : base(brand, speed, numberOfDoors)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} electric car started silently. Battery at {BatteryCapacity}%.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Doors: {NumberOfDoors}, Battery: {BatteryCapacity}%");
        }
    }
}
