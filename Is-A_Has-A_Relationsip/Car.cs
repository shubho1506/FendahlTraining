using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string licensePlate, int maxSpeed, int numberOfDoors)
            : base(licensePlate, maxSpeed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"Car with License Plate {LicensePlate} is starting. Vroom Vroom!");
        }
    }
}
