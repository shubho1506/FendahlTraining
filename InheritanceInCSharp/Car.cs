using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, int speed, int numberOfDoors) : base(brand, speed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} car engine started. Vroom Vroom!");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Doors: {NumberOfDoors}");
        }
    }
}
