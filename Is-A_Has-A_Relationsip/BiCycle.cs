using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class BiCycle : Vehicle
    {
        public string Type { get; set; } 

        public BiCycle(string licensePlate, int maxSpeed, string type)
            : base(licensePlate, maxSpeed)
        {
            Type = type;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"Bicycles don't have an engine! Starting pedaling. ");
        }
    }
}
