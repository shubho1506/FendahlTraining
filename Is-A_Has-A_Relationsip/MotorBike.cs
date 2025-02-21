using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class MotorBike : Vehicle
    {
        public bool HasSidecar { get; set; }

        public MotorBike(string licensePlate, int maxSpeed, bool hasSidecar)
            : base(licensePlate, maxSpeed)
        {
            HasSidecar = hasSidecar;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"Motorbike with License Plate {LicensePlate} is revving up. Brum Brum!");
        }
    }
}
